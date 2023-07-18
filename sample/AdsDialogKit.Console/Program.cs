

using AdsDialogKit;
using AdsDialogKit.Enums;
using AdsDialogKit.Extensions;
using AdsDialogKit.Layouts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

var host = CreateHostBuilder(args).Build();
Application app = host.Services.GetRequiredService<Application>();

static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureServices(
            (_, services) => services
                .AddAdsDialogBox()
                .AddSingleton<Application, Application>()
                .AddSingleton<IAppConfig, AppConfig>());
}
public interface IAppConfig
{
    string Setting { get; }
}
public class AppConfig : IAppConfig
{
    public string Setting { get; }
    public AppConfig()
    {
        Console.WriteLine("AppConfig constructed");
    }
}
public class Application
{
    readonly IAppConfig config;
    readonly IAdsDialogBox _adsDialogBox;
    readonly ILogger<Application> _logger;
    public Application(IAppConfig config, IAdsDialogBox adsDialogBox, ILogger<Application> logger)
    {
        this.config = config;
        this._logger = logger;
        logger.Log(LogLevel.Information, "Application constructed");
        _adsDialogBox = adsDialogBox;
        this.ApplicationExecuteBasicDialogBox();
    }


    public void ApplicationExecuteBasicDialogBox()
    {
        var model = SampleBasicDialogBoxExtensions.BasicDialogInformation(_adsDialogBox);
        var serializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Include,
        };
        var serializedDialogBox = JsonConvert.SerializeObject(model, serializerSettings);
        _logger.Log(LogLevel.Information, serializedDialogBox); 
    }
}


public static class SampleBasicDialogBoxExtensions
{
    public static IAdsBasicDialogBox BasicDialogError(this IAdsDialogBox AdsDialogBox)
    {
        return AdsDialogBox.Basic
            .Header
                .SetTitle("Example Title For the BasicDialogError")
                .Next()
            .Body
                .SetText("Example Description For the BasicDialogError")
                .Next()
            .Footer
                .Button
                    .SetText("Agree")
                    .SetAction(AdsDialogKitButtonAction.GoToDeepLink)
                    .SetLink("")
                    .Next()
                .Button
                    .SetText("Disagree")
                    .SetAction(AdsDialogKitButtonAction.GoToDeepLink)
                    .SetLink("")
                    .Next()
                .Next()
            .Create();
    }

    public static IAdsBasicDialogBox BasicDialogInformation(this IAdsDialogBox AdsDialogBox)
    {
        return AdsDialogBox.Basic
            .Header
                .SetTitle("Example Title For the BasicDialogInformation")
                .Next()
            .Footer
                .Button
                    .SetText("Agree")
                    .SetAction(AdsDialogKitButtonAction.CloseDialog)
                    .Next()
                .Button
                    .SetText("Disagree")
                    .SetAction(AdsDialogKitButtonAction.GoToDeepLink)
                    .SetLink("")
                    .Next()
                .Next()
            .Create();
    }

    public static IAdsBasicDialogBox BasicDialogInformationButDifferentType(this IAdsDialogBox AdsDialogBox)
    {
        return AdsDialogBox.Basic
            .Header
                .SetTitle("Example Title For the BasicDialogInformation")
                .Next()
            .Body
                .SetText("Example Description For the BasicDialogInformation")
                .Next()
            .Footer
                .Button
                    .SetText("Agree")
                    .SetAction(AdsDialogKitButtonAction.GoToDeepLink)
                    .SetLink("")
                    .SetType(AdsDialogKitButtonType.Primary)
                    .Next()
                .Button
                    .SetText("Reminde later")
                    .SetAction(AdsDialogKitButtonAction.CloseDialog)
                    .SetType(AdsDialogKitButtonType.Secondary)
                    .Next()
                .Next()
            .Create();
    }
}
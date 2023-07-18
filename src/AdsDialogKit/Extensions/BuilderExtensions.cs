using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace AdsDialogKit.Extensions
{
    public class AdsDialogBoxOptions
    {
    }

    public static class BuilderExtensions
    {
        public static IServiceCollection AddAdsDialogBox(this IServiceCollection services,
            Action<AdsDialogBoxOptions> setupAction = null)
        {
            services.AddScoped<IAdsDialogBox, AdsDialogBox>();

            var options = new AdsDialogBoxOptions();
            setupAction?.Invoke(options);

            if (setupAction != null)
            {
                services.Configure(setupAction);
            }

            return services;
        }


        public static AdsDialogBox GetDialogBoxModel(HttpContext httpContext)
        {
            var serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include,
            };

            var AdsDialogBox = httpContext.RequestServices.GetRequiredService<IAdsDialogBox>();
            var serializedDialogBox = JsonConvert.SerializeObject(AdsDialogBox, serializerSettings);

            return JsonConvert.DeserializeObject<AdsDialogBox>(serializedDialogBox, serializerSettings);
        }
        
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdsDialogKit.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdsDialogKitButtonAction
    {
        
        GoToUrl,
        GoToDeepLink,
        OpenWebView,
        SendWebRequest,
        CloseDialog,
        Share,
        GrantLocationPermission
    }
}


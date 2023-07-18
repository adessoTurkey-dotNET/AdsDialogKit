using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdsDialogKit.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdsDialogKitViewType
    {
        Image,
        Lottie
    }
}

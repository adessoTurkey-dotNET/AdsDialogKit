using AdsDialogKit.Enums;
using Newtonsoft.Json;

namespace AdsDialogKit.Components.DialogBox
{
    public class AdsDialogBoxButton : AdsDialogBoxComponent
    {
        [JsonProperty]
        protected string Text { get; set; }

        [JsonProperty]
        protected string Link { get; set; }

        [JsonProperty]
        protected string RedirectedScreenTitle { get; set; }

        [JsonProperty]
        protected AdsDialogKitVerb? Verb { get; set; } = null;

        [JsonProperty]
        protected AdsDialogKitButtonAction? Action { get; set; }

        [JsonProperty]
        protected AdsDialogKitButtonType? Type { get; set; } = AdsDialogKitButtonType.Primary;
    }
}

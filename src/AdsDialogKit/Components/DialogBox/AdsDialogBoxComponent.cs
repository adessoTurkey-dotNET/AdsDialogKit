using Newtonsoft.Json;

namespace AdsDialogKit.Components.DialogBox
{
    public abstract class AdsDialogBoxComponent
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnabled { get; set; } = false;
    }
}

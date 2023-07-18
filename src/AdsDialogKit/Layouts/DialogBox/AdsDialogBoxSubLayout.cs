using Newtonsoft.Json;

namespace AdsDialogKit.Layouts
{
    public abstract class AdsDialogBoxSubLayout<TParentLayout>
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnabled { get; set; } = false;

        public abstract TParentLayout Next();
    }
}

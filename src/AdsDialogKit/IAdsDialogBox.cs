using AdsDialogKit.Layouts;
using Newtonsoft.Json;

namespace AdsDialogKit
{
    public interface IAdsDialogBox
    {
        /// <summary>
        /// Most basic dialog box with few components
        /// <para>Contains three layouts: header, body and footer</para>
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        IAdsBasicDialogBox Basic { get; }
    }
}

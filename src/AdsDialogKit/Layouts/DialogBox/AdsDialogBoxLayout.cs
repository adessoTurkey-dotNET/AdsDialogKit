using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Layouts
{
    public abstract class AdsDialogBoxLayout<TLayout> : IAdsDialogBoxLayout
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnabled { get; set; } = false;

        public abstract TLayout Create();
    }
}


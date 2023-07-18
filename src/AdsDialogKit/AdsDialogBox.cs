using AdsDialogKit.Layouts;
using AdsDialogKit.Layouts.DialogBox;
using Newtonsoft.Json;

namespace AdsDialogKit
{

    public class AdsDialogBox : IAdsDialogBox
    {
        public AdsDialogBox()
        {
        }

        [JsonConstructor]
        public AdsDialogBox(
            AdsBasicDialogBox basic)
        {
            var actualDialogBox = this.GetActualDialogBox(basic);
            this.Value = actualDialogBox.Item1;
            this.Type = actualDialogBox.Item2;
            this.Basic = null;
        }

        public IAdsBasicDialogBox Basic { get; set; } = new AdsBasicDialogBox();

        public IAdsDialogBoxLayout Value { get; }

        public string Type { get; }

        #region Helper Methods
        private (IAdsDialogBoxLayout, string) GetActualDialogBox(
            AdsBasicDialogBox basic
           )
        {
            if ((bool)basic.IsEnabled)
            {
                basic.IsEnabled = null;
                return (basic, nameof(this.Basic));
            }
            return (null, null);
        }
        #endregion
    }
}

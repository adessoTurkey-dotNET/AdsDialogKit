using System.Collections.Generic;
using AdsDialogKit.Components.DialogBox;
using Newtonsoft.Json;

namespace AdsDialogKit.Layouts.DialogBox
{

    public class AdsBasicDialogBoxFooter : AdsDialogBoxSubLayout<IAdsBasicDialogBox>, IAdsBasicDialogBoxFooter
    {
        private readonly IAdsBasicDialogBox _dialog;

        [JsonConstructor]
        public AdsBasicDialogBoxFooter(List<AdsBasicDialogBoxButton> buttons)
        {
            this.Buttons = buttons.Count > 0 ? buttons : null;

            this.ClearIsEnabled();
        }

        public AdsBasicDialogBoxFooter(IAdsBasicDialogBox dialog)
        {
            this._dialog = dialog;
            this.Button = new AdsBasicDialogBoxButton(this);
        }

        public List<AdsBasicDialogBoxButton> Buttons { get; set; } = new();

        [JsonIgnore]
        public IAdsBasicDialogBoxButton Button { get; set; }

        public override IAdsBasicDialogBox Next()
        {
            this.IsEnabled = true;
            return this._dialog;
        }

        #region Helper Methods
        private void ClearIsEnabled()
        {
            if (this.Buttons?.Count > 0)
            {
                this.Buttons?.ForEach(x => x.IsEnabled = null);
            }
        }
        #endregion
    }
}

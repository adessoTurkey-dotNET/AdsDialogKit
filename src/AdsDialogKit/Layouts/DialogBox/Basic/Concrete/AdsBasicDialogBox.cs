using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Layouts.DialogBox
{
    public class AdsBasicDialogBox : AdsDialogBoxLayout<IAdsBasicDialogBox>, IAdsBasicDialogBox
    {
        [JsonConstructor]
        public AdsBasicDialogBox(
            AdsBasicDialogBoxHeader header,
            AdsBasicDialogBoxBody body,
            AdsBasicDialogBoxFooter footer)
        {
            this.Header = (bool)header.IsEnabled ? header : null;
            this.Body = (bool)body.IsEnabled ? body : null;
            this.Footer = (bool)footer.IsEnabled ? footer : null;

            this.ClearIsEnabled();
        }

        public AdsBasicDialogBox()
        {
            this.Header = new AdsBasicDialogBoxHeader(this);
            this.Body = new AdsBasicDialogBoxBody(this);
            this.Footer = new AdsBasicDialogBoxFooter(this);
        }

        public IAdsBasicDialogBoxHeader Header { get; set; }

        public IAdsBasicDialogBoxBody Body { get; set; }

        public IAdsBasicDialogBoxFooter Footer { get; set; }

        public override IAdsBasicDialogBox Create()
        {
            this.IsEnabled = true;
            return this;
        }

        #region Helper Methods
        private void ClearIsEnabled()
        {
            if (this.Header != null)
            {
                (this.Header as AdsBasicDialogBoxHeader).IsEnabled = null;
            }

            if (this.Body != null)
            {
                (this.Body as AdsBasicDialogBoxBody).IsEnabled = null;
            }

            if (this.Footer != null)
            {
                (this.Footer as AdsBasicDialogBoxFooter).IsEnabled = null;
            }
        }
        #endregion
    }
}



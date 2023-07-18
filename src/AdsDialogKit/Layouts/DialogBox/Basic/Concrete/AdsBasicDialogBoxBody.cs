namespace AdsDialogKit.Layouts.DialogBox
{
    public class AdsBasicDialogBoxBody : AdsDialogBoxSubLayout<IAdsBasicDialogBox>, IAdsBasicDialogBoxBody
    {
        private readonly IAdsBasicDialogBox _dialog;

        public AdsBasicDialogBoxBody(IAdsBasicDialogBox dialog)
        {
            this._dialog = dialog;
        }

        public string Text { get; set; }

        public string SubText { get; set; }

        public IAdsBasicDialogBoxBody SetText(string text)
        {
            (this._dialog.Body as AdsBasicDialogBoxBody).Text = text;
            return this;
        }

        public IAdsBasicDialogBoxBody SetSubText(string subtext)
        {
            (this._dialog.Body as AdsBasicDialogBoxBody).SubText = subtext;
            return this;
        }

        public override IAdsBasicDialogBox Next()
        {
            this.IsEnabled = true;
            return this._dialog;
        }
    }
}

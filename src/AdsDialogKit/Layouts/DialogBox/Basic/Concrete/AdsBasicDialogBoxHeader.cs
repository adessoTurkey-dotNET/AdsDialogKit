namespace AdsDialogKit.Layouts.DialogBox
{
    public class AdsBasicDialogBoxHeader : AdsDialogBoxSubLayout<IAdsBasicDialogBox>, IAdsBasicDialogBoxHeader
    {
        private readonly IAdsBasicDialogBox _dialog;

        public AdsBasicDialogBoxHeader(IAdsBasicDialogBox dialog)
        {
            this._dialog = dialog;
        }

        public string Title { get; set; }

        public string Emoji { get; set; }

        public bool? IsClosable { get; set; }

        public bool? IsDismissible { get; set; }

        public IAdsBasicDialogBoxHeader SetTitle(string title)
        {
            (this._dialog.Header as AdsBasicDialogBoxHeader).Title = title;
            return this;
        }

        public IAdsBasicDialogBoxHeader SetEmoji(string emoji)
        {
            (this._dialog.Header as AdsBasicDialogBoxHeader).Emoji = emoji;
            return this;
        }

        public IAdsBasicDialogBoxHeader SetIsClosable(bool isClosable)
        {
            (this._dialog.Header as AdsBasicDialogBoxHeader).IsClosable = isClosable;
            return this;
        }

        public IAdsBasicDialogBoxHeader SetIsDismissible(bool isDismissible)
        {
            (this._dialog.Header as AdsBasicDialogBoxHeader).IsDismissible = isDismissible;
            return this;
        }

        /// <summary>
        /// Skip to next layout 
        /// </summary>
        /// <returns>AdsBasicDialogBox</returns>
        public override IAdsBasicDialogBox Next()
        {
            this.IsEnabled = true;
            return this._dialog;
        }
    }
}

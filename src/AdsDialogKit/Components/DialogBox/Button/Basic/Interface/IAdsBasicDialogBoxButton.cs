using AdsDialogKit.Layouts;

namespace AdsDialogKit.Components.DialogBox
{
    public interface IAdsBasicDialogBoxButton : IAdsDialogBoxButton<IAdsBasicDialogBoxButton>
    {
        /// <summary>
        /// Add new button to footer
        /// </summary>
        /// <returns>IAdsCustomDialogBoxBody</returns>
        IAdsBasicDialogBoxFooter Next();
    }
}


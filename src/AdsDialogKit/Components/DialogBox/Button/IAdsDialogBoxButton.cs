using AdsDialogKit.Enums;

namespace AdsDialogKit.Components.DialogBox
{
    public interface IAdsDialogBoxButton<TButton>
    {
        TButton SetText(string text);

        TButton SetLink(string link);

        TButton SetVerb(AdsDialogKitVerb verb);

        TButton SetAction(AdsDialogKitButtonAction action);

        TButton SetType(AdsDialogKitButtonType type);

        TButton SetRedirectedScreenTitle(string redirectedScreenTitle);
    }
}

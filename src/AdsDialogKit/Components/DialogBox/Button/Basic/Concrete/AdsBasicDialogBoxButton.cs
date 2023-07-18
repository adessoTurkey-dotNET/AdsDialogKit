using AdsDialogKit.Enums;
using AdsDialogKit.Layouts;
using AdsDialogKit.Layouts.DialogBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Components.DialogBox
{
    public class AdsBasicDialogBoxButton : AdsDialogBoxButton, IAdsBasicDialogBoxButton
    {
        private readonly IAdsBasicDialogBoxFooter _footer;

        public AdsBasicDialogBoxButton(IAdsBasicDialogBoxFooter footer)
        {
            this._footer = footer;
        }

        public IAdsBasicDialogBoxButton SetText(string text)
        {
            this.Text = text;
            return this;
        }

        public IAdsBasicDialogBoxButton SetLink(string link)
        {
            this.Link = link;
            return this;
        }

        public IAdsBasicDialogBoxButton SetVerb(AdsDialogKitVerb verb)
        {
            this.Verb = verb;
            return this;
        }

        public IAdsBasicDialogBoxButton SetAction(AdsDialogKitButtonAction action)
        {
            this.Action = action;
            return this;
        }

        public IAdsBasicDialogBoxButton SetType(AdsDialogKitButtonType type)
        {
            this.Type = type;
            return this;
        }

        public IAdsBasicDialogBoxButton SetRedirectedScreenTitle(string redirectedScreenTitle)
        {
            this.RedirectedScreenTitle = redirectedScreenTitle;
            return this;
        }

        public IAdsBasicDialogBoxFooter Next()
        {
            (this._footer as AdsBasicDialogBoxFooter).Buttons.Add(this);
            (this._footer as AdsBasicDialogBoxFooter).Button = new AdsBasicDialogBoxButton(this._footer);
            return this._footer;
        }
    }
}

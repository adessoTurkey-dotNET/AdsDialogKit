using AdsDialogKit.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Components.DialogBox
{
    public interface IAdsBasicDialogBoxTopButton : IAdsDialogBoxButton<IAdsBasicDialogBoxTopButton>
    {
        /// <summary>
        /// Skip to next component 
        /// </summary>
        /// <returns>IAdsBasicDialogBoxFooter</returns>
        IAdsBasicDialogBoxFooter Next();
    }
}

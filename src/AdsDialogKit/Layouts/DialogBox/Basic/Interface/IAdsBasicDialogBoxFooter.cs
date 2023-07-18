using AdsDialogKit.Components.DialogBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Layouts
{
    public interface IAdsBasicDialogBoxFooter
    {
        IAdsBasicDialogBoxButton Button { get; set; }

        /// <summary>
        /// Skip to next layout 
        /// </summary>
        /// <returns>IAdsBasicDialogBox</returns>
        IAdsBasicDialogBox Next();
    }
}

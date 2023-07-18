using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Layouts
{
    public interface IAdsBasicDialogBoxBody
    {
        IAdsBasicDialogBoxBody SetText(string text);

        IAdsBasicDialogBoxBody SetSubText(string subtext);

        /// <summary>
        /// Skip to next layout 
        /// </summary>
        /// <returns>IAdsBasicDialogBox</returns>
        IAdsBasicDialogBox Next();
    }
}

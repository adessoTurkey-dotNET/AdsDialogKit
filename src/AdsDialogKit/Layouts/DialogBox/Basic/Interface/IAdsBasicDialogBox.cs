using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Layouts
{
    public interface IAdsBasicDialogBox : IAdsDialogBoxLayout
    {
        /// <summary>
        /// Basic dialog box header
        /// </summary>
        IAdsBasicDialogBoxHeader Header { get; set; }

        /// <summary>
        /// Basic dialog box body
        /// </summary>
        IAdsBasicDialogBoxBody Body { get; set; }

        /// <summary>
        /// Basic dialog box footer
        /// </summary>
        IAdsBasicDialogBoxFooter Footer { get; set; }

        /// <summary>
        /// Creates the dialog box
        /// </summary>
        /// <returns>IAdsBasicDialogBox</returns>
        IAdsBasicDialogBox Create();
    }
}

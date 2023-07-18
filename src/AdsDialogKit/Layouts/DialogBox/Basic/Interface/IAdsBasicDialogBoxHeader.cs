using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsDialogKit.Layouts
{
    public interface IAdsBasicDialogBoxHeader
    {
        IAdsBasicDialogBoxHeader SetTitle(string title);

        IAdsBasicDialogBoxHeader SetEmoji(string emoji);

        IAdsBasicDialogBoxHeader SetIsClosable(bool isClosable);

        IAdsBasicDialogBoxHeader SetIsDismissible(bool isDismissible);

        IAdsBasicDialogBox Next();
    }
}

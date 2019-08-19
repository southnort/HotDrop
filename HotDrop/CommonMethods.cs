using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotDrop
{
    class CommonMethods
    {
        public static void CopyText(TextBoxBase textBox)
        {
            if (textBox.Text.Length > 0)
                Clipboard.SetText(textBox.Text);
        }

    }
}

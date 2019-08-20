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

        public static int GetInt(object val)
        {
            if (val is DBNull) return 0;
            else
                return (int)(long)val;

        }

        public static string GetStr(object val)
        {
            if (val is DBNull) return "";
            else
                return val.ToString();
        }

        public static float GetFloat(object val)
        {
            if (val is DBNull) return 0f;
            else
                return (float)val;
        }

    }
}

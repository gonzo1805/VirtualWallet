using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace VirtualWallet
{
    public static class Utilities
    {
        public static bool ContainsSpecialCharacters(string text)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            return regexItem.IsMatch(text);
        }
    }
}

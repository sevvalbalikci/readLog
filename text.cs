using System.Globalization;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readLog
{
    public static class TextHelper
    {
        public static string ToProperCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }
    }
}

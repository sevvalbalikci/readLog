using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readLog
{
    public static class TextHelper
    {
        public static string ToProperCase(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            CultureInfo tr = new CultureInfo("tr-TR");
            value = value.ToLower(tr);
            return tr.TextInfo.ToTitleCase(value);
        }
    }
}

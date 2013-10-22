using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberText
{
    public static class NumberTextExtention
    {
        public static string ToText(this int number)
        {
            NumberTextConverter converter = new NumberTextConverter();
            return converter.ToText(number);
        }

        public static string ToText(this int number,StringLanguage lang)
        {
            NumberTextConverter converter = new NumberTextConverter(lang);
            return converter.ToText(number);
        }
    }
}

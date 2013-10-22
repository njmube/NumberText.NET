using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberText.NET
{
    public static class NumberTextExtention
    {
        public static string ToText(this int number)
        {
            NumberText converter = new NumberText();
            return converter.ToText(number);
        }

        public static string ToText(this int number,StringLanguage lang)
        {
            NumberText converter = new NumberText(lang);
            return converter.ToText(number);
        }
    }
}

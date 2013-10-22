using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberText.NET
{
    public class NumberText
    {
        private Dictionary<int, string> Texts;
        private Dictionary<int, string> scales = new Dictionary<int, string>();

        private StringBuilder builder;

        public NumberText()
        {
            Texts = new Dictionary<int, string>();
            Strings.Initialize(StringLanguage.English);
            Texts = Strings.texts;
        }

        public string ToText(int num)
        {
            builder = new StringBuilder();

            if (QuickText(num))
                return builder.ToString();

            string rawnumber = num.ToString();
            char[] a = rawnumber.ToCharArray();
            Array.Reverse(a);

            return builder.ToString().Trim();
        }

        private bool QuickText(int num)
        { 
            string value = "";
            if (Texts.TryGetValue(num, out value))
            {
                builder.Append(Texts[num].ToString());
                return true;
            }
            else return false;                
        }


        
        private void AppendUnits(int num)
        {
            if (num > 0)
            {
                builder.AppendFormat("{0} ", Texts[num]);
            }
        }

        private int AppendTens(int num)
        {
            if (num > 20)
            {
                var tens = ((int)(num / 10)) * 10;
                builder.AppendFormat("{0} ", Texts[tens]);
                num = num - tens;
            }
            return num;
        }

        private int AppendHundreds(int num)
        {
            if (num > 99)
            {
                var hundreds = ((int)(num / 100));
                builder.AppendFormat("{0} hundred ", Texts[hundreds]);
                num = num - (hundreds * 100);
            }
            return num;
        }

    }
}

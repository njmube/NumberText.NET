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

        public NumberText()
        {
            Texts = new Dictionary<int, string>();
            Strings.Initialize(StringLanguage.Turkish);
            Texts.Clear();
            Texts = Strings.texts;
        }

        public NumberText(StringLanguage lang)
        {
            Texts = new Dictionary<int, string>();
            Strings.Initialize(lang);
            Texts.Clear();
            Texts = Strings.texts;
        }

        public string ToText(int num)
        {
            string builder = String.Empty;

            if (num < 0)
                return Texts[-1] + ToText(Math.Abs(num));

            //if (QuickText(num))
            //    return builder.ToString();

            if ((num / 1000000) > 0)
            {
                //if ((num / 1000000) != 1)
                builder += ToText(num / 1000000);
                builder += " " + Texts[1000000];
                num %= 1000000;
            }

            if ((num / 1000) > 0)
            {
                if ((num / 1000) != 1)
                    builder += ToText(num / 1000);
                builder += " " + Texts[1000];
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                if ((num / 100) != 1)
                    builder += ToText(num / 100);
                builder += " " + Texts[100];
                num %= 100;
            }

            if (num > 0)
            {
                if (!String.IsNullOrEmpty(builder.ToString()))
                    builder += " ";

                if (num < 20)
                    builder += Texts[num];
                else
                {
                    builder += Texts[(num / 10) * 10];
                    if ((num % 10) > 0)
                        builder += " " + Texts[num % 10];
                }
            }

            //string rawnumber = num.ToString();
            //char[] a = rawnumber.ToCharArray();
            //Array.Reverse(a);

            builder += "";
            return builder.ToString().Trim();
        }

        //private bool QuickText(int num)
        //{ 
        //    string value = "";
        //    if (Texts.TryGetValue(num, out value))
        //    {
        //        builder.Append(Texts[num].ToString());
        //        return true;
        //    }
        //    else return false;                
        //}
    }
}

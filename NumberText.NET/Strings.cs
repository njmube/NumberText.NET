using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberText.NET
{
    public enum StringLanguage
    { 
        English,
        Turkish
    }

    public static class Strings
    {
        public static Dictionary<int, string> texts;
        public static StringLanguage language;

        public static void Initialize(StringLanguage lang) 
        {
            texts = new Dictionary<int, string>();
            language = lang;

            if (lang.Equals(StringLanguage.English))
                GetValues_EN();
            else GetValues_TR();
        }

        private static void GetValues_EN()
        {
            texts.Add(0, "zero");
            texts.Add(1, "one");
            texts.Add(2, "two");
            texts.Add(3, "three");
            texts.Add(4, "four");
            texts.Add(5, "five");
            texts.Add(6, "six");
            texts.Add(7, "seven");
            texts.Add(8, "eight");
            texts.Add(9, "nine");
            texts.Add(10, "ten");
            texts.Add(11, "eleven");
            texts.Add(12, "twelve");
            texts.Add(13, "thirteen");
            texts.Add(14, "fourteen");
            texts.Add(15, "fifteen");
            texts.Add(16, "sixteen");
            texts.Add(17, "seventeen");
            texts.Add(18, "eighteen");
            texts.Add(19, "nineteen");
            texts.Add(20, "twenty");
            texts.Add(30, "thirty");
            texts.Add(40, "forty");
            texts.Add(50, "fifty");
            texts.Add(60, "sixty");
            texts.Add(70, "seventy");
            texts.Add(80, "eighty");
            texts.Add(90, "ninety");
            texts.Add(100, "hundred");

            texts.Add(1000000000, "billion");
            texts.Add(1000000, "million");
            texts.Add(1000, "thousand");
        }

        private static void GetValues_TR()
        {
            texts.Add(0, "sıfır");
            texts.Add(1, "bir");
            texts.Add(2, "iki");
            texts.Add(3, "üç");
            texts.Add(4, "dört");
            texts.Add(5, "beş");
            texts.Add(6, "altı");
            texts.Add(7, "yedi");
            texts.Add(8, "sekiz");
            texts.Add(9, "dokuz");
            texts.Add(10, "on");
            texts.Add(11, "onbir");
            texts.Add(12, "oniki");
            texts.Add(13, "onüç");
            texts.Add(14, "ondört");
            texts.Add(15, "onbeş");
            texts.Add(16, "onaltı");
            texts.Add(17, "onyedi");
            texts.Add(18, "onsekiz");
            texts.Add(19, "ondokuz");
            texts.Add(20, "yirmi");
            texts.Add(30, "otuz");
            texts.Add(40, "forty");
            texts.Add(50, "fifty");
            texts.Add(60, "sixty");
            texts.Add(70, "seventy");
            texts.Add(80, "eighty");
            texts.Add(90, "ninety");
            texts.Add(100, "hundred");

            texts.Add(1000000000, "billion");
            texts.Add(1000000, "million");
            texts.Add(1000, "thousand");
        }
    }
}

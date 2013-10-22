using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberText;

namespace NumberText.NET.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(2 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(2));

            Console.Write(19 + "->");
            Console.WriteLine(new NumberTextConverter().ToText(19));

            Console.Write(963 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(963));

            Console.Write(1598 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(1598));

            Console.Write(78965 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(78965));

            Console.Write(147896 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(147896));

            Console.Write(10 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(10));

            Console.Write(100 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(100));

            Console.Write(1000 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(1000));

            Console.Write(10000 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(10000));

            Console.Write(100000 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(100000));

            Console.Write(1000000 + "-> ");
            Console.WriteLine(new NumberTextConverter().ToText(1000000));

            NumberTextConverter converter = new NumberTextConverter();
            Console.WriteLine("123456 -> " + converter.ToText(123456));

            int value = 1236;
            Console.WriteLine(value.ToText());
            Console.WriteLine(value.ToText(StringLanguage.English));

            Console.ReadLine();
        }
    }
}

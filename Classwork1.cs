using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "C# обладает эффективными средствами обработки строк";
            string str2 = "о";
            string str3 = "ми";
            string str4 = "а";
            string str5 = "б";
            string str6 = "в";
            bool x = str.StartsWith("C# обладает");
            bool y = str.EndsWith("строк");
            int i = str.IndexOf(str2);
            int i2 = str.LastIndexOf(str2);
            int i3 = str.IndexOf(str3);
            int i4 = str.LastIndexOf(str3);
            int i5 = str.IndexOf(str4);
            int i6 = str.IndexOf(str5);
            int i7 = str.IndexOf(str6);
            int number = Math.Min(i5, i6);
            int number1 = Math.Min(i6, i7);
            int number3 = Math.Min(number, number1);
            Console.WriteLine("Индекс первого вхождения символа 'о': " + i);
            Console.WriteLine("Индекс последнего вхождения символа 'о' : " + i2);
            Console.WriteLine("Индекс первого вхождения подстроки 'ми' : " + i3);
            Console.WriteLine("Индекс последнего вхождения подстроки 'ми' : " + i4);
            Console.WriteLine("Индекс первого вхождения символов 'а' , 'б' или 'в' : " + number3);
            if (x == true)
            {
                Console.WriteLine("Строка str начинается с подстроки 'C# обладает'");
            }
            if (y==true)
                Console.WriteLine("Строка str оканчивается подстрокой 'строк'"); ;
            Console.ReadKey();
        }
    }
}

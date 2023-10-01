using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Введите строку в которой больше 3 символов с : и с !");
            string str = "::asdasd!!";
            string str2 = ":";
            string str3 = "!";
            int n = str.Length;
            int first = n / 2;
            string proverka = str.Substring(0, first);
            string proverka1 = str.Substring(first);
            if (proverka.Contains(":") && proverka1.Contains("!"))
            {
                string Replace = str.Replace(":", "*");
                string Replace2 = str.Replace("!", ".");
                Console.WriteLine("Новая строка: " + Replace);
                Console.WriteLine("Новая строка: " + Replace2);

            }
           
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}

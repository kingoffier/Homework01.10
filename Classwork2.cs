using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Это тест";
            string s2 = " простой";
            Console.WriteLine($"Исходная строка: {str}");
            s2 = str.Insert(3, s2);
            Console.WriteLine("Новая строка: "+s2);
            Console.ReadKey();
        }
    }
}

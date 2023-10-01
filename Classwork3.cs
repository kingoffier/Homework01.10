using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "это простой тест";
            string s2;
            string s3;
            s2 = s1.Replace("п", "неп");
            s3 = s2.Replace("е", "о");
            Console.WriteLine("Исходная строка: "+s1);
            Console.WriteLine("Новая строка: "+s2);
            Console.WriteLine("Новая строка: "+s3);
        }
    }
}

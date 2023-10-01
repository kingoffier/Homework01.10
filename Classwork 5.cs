using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "dfgdf(gdfgss)dg";
            int i = s1.IndexOf("(");
            int j = s1.IndexOf(")");
            Console.WriteLine(i);
            Console.WriteLine(j);
            if (i < j)
            {
                string rez = s1.Substring(i + 1, j - i - 1);
                Console.WriteLine("Символы между скобками: " + rez);
            }
            Console.ReadKey();
        }
    }
}

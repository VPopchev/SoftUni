using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal buildersSalary = 1500.04m;
            decimal receptionistsSalary = 2102.10m;
            decimal chambermaidsSalay = 1465.46m;
            decimal technicansSalary = 2053.33m;
            decimal othersSalary = 3010.98m; 

            int b = int.Parse(Console.ReadLine());
            buildersSalary *= b;
            int r = int.Parse(Console.ReadLine());
            receptionistsSalary *= r;
            int c = int.Parse(Console.ReadLine());
            chambermaidsSalay *= c;
            int t = int.Parse(Console.ReadLine());
            technicansSalary *= t;
            int o = int.Parse(Console.ReadLine());
            othersSalary *= o;
            decimal n = decimal.Parse(Console.ReadLine());
            decimal u = decimal.Parse(Console.ReadLine());
            decimal s = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            n *= u;
            decimal amount = buildersSalary + receptionistsSalary +
                chambermaidsSalay + technicansSalary + othersSalary + n + s;
            Console.WriteLine("The amount is: {0:0.00} lv.", amount);
            Console.WriteLine("{0} \\ {1}: {2:f2} lv.",
            amount <= m ? "YES" : "NO",
            amount <= m ? "Left" : "Need more",
            Math.Abs(m - amount));

        }
    }
}

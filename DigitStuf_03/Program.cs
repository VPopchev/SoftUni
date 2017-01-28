using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitStuf_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            a = n % 10;
            n = n / 10;
            b = n % 10;
            n = n / 10;
            c = n % 10;
            n = n / 10;
            d = n % 10;
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", a,b,c,d);
            Console.WriteLine("{0}{1}{2}{3}", a, d, c, b);
            Console.WriteLine("{0}{1}{2}{3}", d, b, c, a);
            }
        }
    }


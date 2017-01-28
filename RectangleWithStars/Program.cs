using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', n * 2)); // top
            if (n % 2 == 0)
            {
                for (int i = 1; i < n / 2; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('%', 1), new string(' ', (n * 2) - 2));
                }
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('%', 1), new string(' ', n - 2), new string('*', 2));
                for (int i = (n / 2) - 1; i >= 1; i--)
                {
                    Console.WriteLine("{0}{1}{0}", new string('%', 1), new string(' ', (n * 2) - 2));
                }
                Console.WriteLine(new string('%', n * 2));
            }
            else
            {
                for (int i = 1; i < (n / 2) + 1; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('%', 1), new string(' ', (n * 2) - 2));
                }
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('%', 1), new string(' ', n - 2), new string('*', 2));
                for (int i = (n / 2) + 1; i > 1; i--)
                {
                    Console.WriteLine("{0}{1}{0}", new string('%', 1), new string(' ', (n * 2) - 2));
                }
                Console.WriteLine(new string('%', n * 2));

            }
        }
    }
}

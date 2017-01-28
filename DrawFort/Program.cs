using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0 && n > 4)
            {                           
                Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2),new string('_', n / 2));
                for(int i = 1; i <= n - 3; i++)
                {
                    Console.WriteLine("|{0}|",new string(' ', n / 2 + n + 2));
                }
                Console.WriteLine("|{0}{1}{0}|",new string(' ', n / 2 + 1), new string('_', n / 2));
                Console.WriteLine("\\{0}/{1}\\{0}/",new string('_', n / 2), new string(' ', n / 2 ));
            }
            if(n % 2 != 0)
            {
                Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', n / 2));
                for (int i = 1; i <= n - 3; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', n / 2 + n + 1));
                }
                Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string('_', n / 2));
                Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', n / 2));

            }

            if (n <= 4 && n > 2)
            {
                Console.WriteLine("/{0}\\/{0}\\", new string('^', n / 2));
                for (int i = 1; i <= n - 2; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', n * 2 - 2));
                }
                Console.WriteLine("\\{0}/\\{0}/", new string('_', n / 2));
            }

            
            
        }
    }
}

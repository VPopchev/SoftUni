using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1 = long.Parse(Console.ReadLine());
            long n2 = long.Parse(Console.ReadLine());

            var operation = Console.ReadLine();
            if(operation == "+")
            {
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operation, n2, n1 + n2, (n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (operation == "-")
            {
                 Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operation, n2, n1 - n2, (n1 - n2) % 2 == 0 ? "even" : "odd");
            }
            else if (operation == "*")
            {
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operation, n2, n1 * n2, (n1 * n2) % 2 == 0 ? "even" : "odd");
            }
            else if(operation == "/" && n2 != 0)
            {
                Console.WriteLine("{0} / {1} = {2:F2}",n1,n2,(double)n1 / n2);
            }
            else if(operation == "%" && n2 != 0)
            {
                Console.WriteLine("{0} % {1} = {2}", n1, n2,(double) n1 % n2);
            }
            if(n2 == 0 && operation == "/" || n2 == 0 && operation == "%")
            {
                Console.WriteLine("Cannot divide {0} by zero",n1);
            }

        }
    }
}

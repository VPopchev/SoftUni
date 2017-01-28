using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeVariables02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter 1st value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter 2nd value: ");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("1st={0}/2nd={1}", a, b);

        }
    }
}

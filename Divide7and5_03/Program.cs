using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide7and5_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            bool prime = false;
            if (n % 35 == 0)
            {
                prime = true;
                Console.WriteLine("DivideBy7and5?:{0} ", prime);
            }
            else
            {
                Console.WriteLine("DivideBy7and5?:{0}", prime);
            }
        }
    }
}

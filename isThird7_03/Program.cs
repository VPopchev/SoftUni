using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isThird7_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            bool isThird7 = false;
            n = n / 100;
                if (n % 10 == 7)
                {
                    isThird7 = true;   
                }           
            
            Console.WriteLine("is third digit = 7? {0}", isThird7);

        }
    }
}
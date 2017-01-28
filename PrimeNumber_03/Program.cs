using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                n = n % i;
                if(n == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine("is Number Prime?:{0}",prime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOver3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;

            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int k = 0; k < n; k += 3)
            {
                sum1 += array[k];
            }
            for(int s = 1; s < n; s += 3)
            {
                sum2 += array[s];
            }
            for(int t = 2; t < n; t += 3)
            {
                sum3 += array[t];
            }
            Console.WriteLine("sum1 = {0}",sum1);
            Console.WriteLine("sum2 = {0}",sum2);
            Console.WriteLine("sum3 = {0}",sum3);
        }
    }
}

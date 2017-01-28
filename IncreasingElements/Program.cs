using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
  
            int start = 0;
            int len = 0;
            int bestLen = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num > start || i == 0)
                {
                    len++;
                }
                else
                {
                    len = 1;
                }
                if(len > bestLen)
                {
                    bestLen = len;
                }
                start = num;
            }
            Console.WriteLine(bestLen);
        }
    }
}


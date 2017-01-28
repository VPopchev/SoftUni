using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum0of5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int sum = 0;
            int currSum;
            int n = array.Length / array.Length - 5;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine()); 
            }
            
            for(int i = 0;i < Math.Pow(2,array.Length); i++)
            {
                Console.WriteLine(i);
            }       
   }
  }
 }
            
   
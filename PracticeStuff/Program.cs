using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class Program
    {
        static void gen(int index,int[] vector)
        {
            if(index == -1)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(vector[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for(int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    gen(index - 1, vector);
                    
                }
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 3, -2, 1, 1, 8 };
            int size = 5;
            int[] vector = new int[size];
            gen(size - 1, vector);
        }
    }
}

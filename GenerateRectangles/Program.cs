using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class Program
    {
        static void Gen(int index, int[] vector)
        {
            if(index == -1)
            {
                if(Math.Abs(vector[0] - vector[2]) == 2 || Math.Abs(vector[1] - vector[3]) == 2)
                {
                    Console.WriteLine(vector);
                }
            }
            else
            {
                for(int i = -1; i <= 1; i++)
                {
                    vector[index] = i;
                    Gen(index - 1, vector);
                }
            }
        }
        static void Main(string[] args)
        {
            int size = 4;
            int[] vector = new int[size];
            Gen(size - 1, vector);
        }
    }
}

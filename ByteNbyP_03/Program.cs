using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteNbyP_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N= ");
            byte n = byte.Parse(Console.ReadLine());
            Console.Write("P= ");
            byte p = byte.Parse(Console.ReadLine());
            int sum = n & p;
            if(sum != 0)
            {
                Console.WriteLine("The P Byte of N is 1!");
            }
            else
            {
                Console.WriteLine("The P Byte of N is 0!");
            }
        }
    }
}

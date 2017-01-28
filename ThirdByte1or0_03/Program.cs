using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdByte1or0_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number");
            byte n = byte.Parse(Console.ReadLine());
            int  a = n & 8;
            if(a != 0)
            {
                Console.WriteLine("Third Byte is 1!");
            }
            else
            {
                Console.WriteLine("Third Byte is 0!");
            }
        }
    }
}

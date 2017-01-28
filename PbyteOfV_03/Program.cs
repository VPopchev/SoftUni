using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PbyteOfV_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("P= ");
            byte p = byte.Parse(Console.ReadLine());
            Console.Write("V= ");
            int v = int.Parse(Console.ReadLine());
            bool pOne = false;
            int i = 1;
            int mask = i << p;
            if((v & mask) != 0)
            {
                pOne = true;
            }
           
            Console.WriteLine("p=1?:{0}", pOne);
        }
    }
}

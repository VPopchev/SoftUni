using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            bool prime = false;
            if(n % 2 == 0)
            {
                prime = true;
                Console.WriteLine("Prime?:{0} ", prime);
            }
            else
            {
                Console.WriteLine("Prime?:{0}", prime);
            }

        }
    }
}

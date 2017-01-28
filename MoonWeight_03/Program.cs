using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonWeight_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Numer(kg): ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your weight on moon is: {0}kg", number * 0.17);
        }
    }
}

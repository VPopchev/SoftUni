using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool isIn = false;
            if(x>=4 && x<= 10 && y >= -5 && y <= 3 || y>= -3 && y <= 1 && x <= 12 && x >= 2)
            {
                isIn = true;
            }
            else if(x <= 4 && x >= 2 && y >= -3 && y <= 1 || x >= 10 && x<=12 && y >= 3 && y <= 1 || y <= -3 && y >= -5 && x >= 4 && x <= 10) {

                isIn = true;
            }
            else
            {
                isIn = false;
            }
            Console.WriteLine(isIn ? "in" : "out");

        }
    }
}

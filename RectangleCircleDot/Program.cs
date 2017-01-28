using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCircleDot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X of Dot: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y of Dot");
            int y = int.Parse(Console.ReadLine());
            bool inCircle = false;
            bool inRect = false;
           if((x*x) + (y*y) <= 25)
            {
                inCircle = true;
            }
           if(x < 5 && x > -1 && y < 5 && y > 1)
            {
                inRect = true;
            }
            Console.WriteLine("is Dot In Circle: {0}", inCircle);
            Console.WriteLine("is Dot In Rectangle: {0}", inRect);
        }
    }
}

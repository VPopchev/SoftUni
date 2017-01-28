using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = "*";
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }
        }
    }
}

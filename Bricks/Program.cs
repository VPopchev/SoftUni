﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            var bricksPerWorker = w * m;
            var courseNeeded = ( x / bricksPerWorker);
            if(x % bricksPerWorker != 0)
            {
                courseNeeded++;
            }
            Console.WriteLine(courseNeeded);
        }
    }
}

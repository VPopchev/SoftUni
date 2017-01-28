using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter_5_days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            int add5 = day + 5;
            var formatDay = 0;
            var fomatMonth = month;

            if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if(add5 > 31)
                {
                    formatDay = add5 - 31;
                    fomatMonth++;
                }
                else
                {
                    formatDay = add5;
                }
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if(add5 > 30)
                {
                    formatDay = add5 - 30;
                    fomatMonth++;
                }
                else
                {
                    formatDay = add5;
                }
            }
            if(month == 2)
            {
                if(add5 > 28)
                {
                    formatDay = add5 - 28;
                    fomatMonth++;
                }
                else
                {
                    formatDay = add5;
                }
            }
            if (fomatMonth > 12)
            {
                fomatMonth = 1;
            }
            if (fomatMonth < 10)
            {
                Console.WriteLine("{0}.0{1}", formatDay, fomatMonth);
            }
            else
            {
                Console.WriteLine("{0}.{1}", formatDay, fomatMonth);
            }
        }
    }
}

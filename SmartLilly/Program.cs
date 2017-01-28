using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double machineCost = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int evenDays = 0;
            int oddDays = 0;
            var bonus = 10;
            var savings = 0;
            for(int i = 1; i <= years; i++)
            {
                if(i % 2 == 0)
                {
                    savings += bonus;
                    evenDays++;
                    bonus += 10;
                }
                else if (i % 2 != 0)
                {
                    oddDays++;
                }
            }
            var brother = 1 * evenDays;
            double earnFromToys = toyPrice * oddDays;
            var totalMoney = earnFromToys + savings - brother;
            if(machineCost > totalMoney)
            {
                Console.WriteLine("No! {0:0.00}",machineCost - totalMoney);
            }
            else
            {
                Console.WriteLine("Yes! {0:0.00}",totalMoney - machineCost);
            }
        }
    }
}

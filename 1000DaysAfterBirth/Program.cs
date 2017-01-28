using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime result = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.CurrentCulture);
            result = result.AddDays(999);
            Console.WriteLine(result.ToString("dd-MM-yyyy"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFirm02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lName = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter gender(m/f): ");
            string gender = Console.ReadLine();
            Console.Write("Enter worker ID: ");
            long id = long.Parse(Console.ReadLine());
            Console.WriteLine(fName + " " + lName + " " + age + " " + "gender: " + gender + " id:" + id);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var numberWord = "";
            var tens = number / 10;
            var ones = number % 10;
            if (ones == 1)
            {
                numberWord += "one";
            }
            if (ones == 2)
            {
                numberWord += "two";
            }
            if (ones == 3)
            {
                numberWord += "three";
            }
            if (ones == 4)
            {
                numberWord += "four";
            }
            if (ones == 5)
            {
                numberWord += "five";
            }
            if (ones == 6)
            {
                numberWord += "six";
            }
            if (ones == 7)
            {
                numberWord += "seven";
            }
            if (ones == 8)
            {
                numberWord += "eight";
            }
            if (ones == 9)
            {
                numberWord += "nine";
            }
            if (ones == 10)
            {
                numberWord += "ten";
            }
            if(tens == 2 && ones != 0)
            {
                numberWord = "twenty " + numberWord;
            }
            else if (tens == 3 && ones != 0)
            {
                numberWord = "thirty " + numberWord;
            }
            else if (tens == 4 && ones != 0)
            {
                numberWord = "fourty " + numberWord;
            }
            else if (tens == 5 && ones != 0)
            {
                numberWord = "fifty " + numberWord;
            }
            else if (tens == 6 && ones != 0)
            {
                numberWord = "sixty " + numberWord;
            }
            else if (tens == 7 && ones != 0)
            {
                numberWord = "seventy " + numberWord;
            }
            else if (tens == 8 && ones != 0)
            {
                numberWord = "eighty " + numberWord;
            }
            else if (tens == 9 && ones != 0)
            {
                numberWord = "ninety " + numberWord;
            }
            if (number == 0)
            {
                numberWord = "zero";
            }
            if (number == 20)
            {
                numberWord = "twenty";
            }
            if (number == 30)
            {
                numberWord = "thirty";
            }
            if (number == 40)
            {
                numberWord = "fourty";
            }
            if (number == 50)
            {
                numberWord = "fifty";
            }
            if (number == 60)
            {
                numberWord = "sixty";
            }
            if (number == 70)
            {
                numberWord = "seveny";
            }
            if (number == 80)
            {
                numberWord = "eighty";
            }
            if (number == 90)
            {
                numberWord = "ninety";
            }
            if (number == 10)
            {
                numberWord = "ten";
            }

            if (number == 11)
            {
                numberWord = "eleven";
            }
            if (number == 12)
            {
                numberWord = "twelve";
            }
            if (number == 13)
            {
                numberWord = "thirteen";
            }
            if (number == 14)
            {
                numberWord = "fourteen";
            }
            if (number == 15)
            {
                numberWord = "fifteen";
            }
            if (number == 16)
            {
                numberWord = "sixteen";
            }
            if (number == 17)
            {
                numberWord = "seventeen";
            }
            if (number == 18)
            {
                numberWord = "eighteen";
            }
            if (number == 19)
            {
                numberWord = "nineteen";
            }
            if (number == 100)
            {
                numberWord = "one hundred";
            }
            if(number < 0 || number > 100)
            {
                numberWord = "invalid number";
            }
            Console.WriteLine(numberWord);
        }
    }
}

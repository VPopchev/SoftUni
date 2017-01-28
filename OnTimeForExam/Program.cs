using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExamHour = int.Parse(Console.ReadLine());
            int ExamMinute = int.Parse(Console.ReadLine());
            int StudentHour = int.Parse(Console.ReadLine());
            int StudentMinute = int.Parse(Console.ReadLine());

            var examTime = ExamHour * 60 + ExamMinute;
            var studentTime = StudentHour * 60 + StudentMinute;
            var difference = studentTime - examTime;

            if (difference < -30)
            
                Console.WriteLine("Early");
            
            else if (difference <= 0)
            
                Console.WriteLine("On time");
            
            else
            
                Console.WriteLine("Late");
            
            if (difference != 0)
            {
                var hours = Math.Abs(difference / 60);
                var minutes = Math.Abs(difference % 60);
                if (hours > 0)
                {
                    if (minutes < 10)

                        Console.Write(hours + ":0" + minutes + " hours");

                    else

                        Console.Write(hours + ":" + minutes + " hours");

                }
                else
                
                    Console.Write(minutes + " minutes");
                    if (difference < 0)
                        Console.Write(" before the start");
                    else
                        Console.Write(" after the start");

                
            }
        }
    }
}

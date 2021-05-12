using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubmission_Statement
{
    class Program
    {
        static void Main()
        //This is a simple program
        //Console.WriteLine("What is your name?");
        //string yourName = Console.ReadLine();
        //Console.WriteLine("Your name is: " + yourName);
        //Console.ReadLine();

        //Console.WriteLine("What is your favorite number?");
        //string favoriteNumber =Console.ReadLine();
        //int favNum = Convert.ToInt32(favoriteNumber);
        //int total = favNum + 5;
        //Console.WriteLine("Your favorite number plus 5 is: " + total);
        //Console.ReadLine();
        {
            Console.WriteLine("This is the Tech Academy.");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);

            Console.WriteLine("What course are you on?");
            string whatCourse = Console.ReadLine();
            Console.WriteLine("You are on course: " + whatCourse);

            Console.WriteLine("What page number?");
            string whatPage = Console.ReadLine();
            int whatNumber = Convert.ToInt32(whatPage);
            Console.WriteLine("You are on page: " + whatPage);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.");
            string needHelp = Console.ReadLine();
            bool iNeedhelp = Convert.ToBoolean(needHelp);
            if (iNeedhelp = true)
            {
                Console.WriteLine("You need help.");
            }
            else
            {
                Console.WriteLine("You dont need help.");
            }
                       
                      
            

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string specifics = Console.ReadLine();
            Console.WriteLine("Your answer: " + specifics);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("Your answer: " + feedBack);


            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hourStudied = Convert.ToInt32(hoursStudied);
            Console.WriteLine("You studied: " + hourStudied + "hrs.");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        Console.ReadLine();


        }
    }
}

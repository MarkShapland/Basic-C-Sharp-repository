using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to have it multiplied by 50.");
            string product = Console.ReadLine();
            double Product = Convert.ToDouble(product);
            double product50 = Product * 50;
            Console.WriteLine(Product + " x 50 = " + product50);
           

            Console.WriteLine("Enter a number to have 25 added to it.");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            int num3 = num2 + 25;
            Console.WriteLine(num2 + " + 25 = " + num3);
           

            Console.WriteLine("Enter a number to have it divided by 12.5");
            string num4 = Console.ReadLine();
            double num5 = Convert.ToDouble(num4);
            double num6 = num5 / 12.5;
            Console.WriteLine(num5 + "/" + "25 = " + num6);
            

            Console.WriteLine("Enter a number to see if it is greater than 50.");
            string num7 = Console.ReadLine();
            int num8 = Convert.ToInt32(num7);
            bool greaterOrLessthan = num8 > 50;
            Console.WriteLine(greaterOrLessthan.ToString());
            
            Console.WriteLine("Enter a to see the remainder when it is devided by 7.");
            string num9 = Console.ReadLine();
            int num10 = Convert.ToInt32(num9);
            double remainder = num10 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();








        }
    }
}

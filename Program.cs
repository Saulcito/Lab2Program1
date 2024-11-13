using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            Console.WriteLine("Enter the value of x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = 2.8;
            double b = -0.3;
            double y =0;

            if (x < 1.2)
            {
                y = a * Math.Pow(x, 2) + b * x;
            }
            else if (y == 1.2)
            {
                y = a / x + Math.Sqrt(Math.Pow(x, 2) + 1);
            }
            else
            {
                y = (a + b * x) / Math.Sqrt(Math.Pow(x, 2) + 1);
            }
            Console.WriteLine($"The value of y: {y}");
            Console.ReadKey();

            

            Console.WriteLine("task 2");
            Console.WriteLine("Enter three numbers:");
            Console.Write("First number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Third number");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double max = number1;
            if (number2 > max) max = number2;
            if (number3 > max) max = number3;

            double min = number1;
            if (number2 < min) min = number2;
            if (number3 < min) min = number3;
            Console.WriteLine($"The greater number is: {max}");
            Console.WriteLine($"The smallest number is: {min}");
            Console.ReadKey();



            Console.WriteLine("task 3");
            Console.WriteLine("Enter the number of the unit of measure:");
            Console.WriteLine("1 - Decimeter");
            Console.WriteLine("2 - Kilometer");
            Console.WriteLine("3 - Meter");
            Console.WriteLine("4 - Millimeter");
            Console.WriteLine("5 - Centimeter");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the segment (L): ");
            double L = Convert.ToDouble(Console.ReadLine());
            double LengthInMeters;
            switch(opcion)
            {
                case 1:
                    LengthInMeters = L / 10; //decimeter to meters
                    break;

                 case 2:
                    LengthInMeters = L * 1000; //kilometer to meters
                    break;

                 case 3:
                    LengthInMeters = L; //It is in meters
                    break;

                 case 4:
                    LengthInMeters = L / 1000; //millimeters to meters
                    break;
                 case 5:
                    LengthInMeters = L / 100; //centimeters to meters
                    break;

                default:
                    Console.WriteLine("Invalid option");
                return;

            }

            Console.WriteLine($"The length of the segment in meters is: {LengthInMeters} m");
            Console.ReadKey ();

        }
    }
}

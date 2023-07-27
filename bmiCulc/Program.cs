using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiCulc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________BMI_Calculator__________");
            Console.Write("Enter your weight (in kg) : ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height (in  m) :  ");
            double height = double.Parse(Console.ReadLine());
            double bmi;
            bmi = BmiCulculator(weight, height);
            Console.WriteLine($"your bmi is {bmi:F2}");

            Console.WriteLine("Interpretation:");
            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight ");
            }
            else if (18.5 >= bmi && bmi < 24.9)
            {
                Console.WriteLine(" You are normal ");
            }
            else if (25 <= bmi && bmi < 29.9)
            {
                Console.WriteLine("You are Overweight ");
            }
            else
            {
                Console.WriteLine("You are going to explode ");
            }
                    
            Console.ReadLine();
        }
        static double BmiCulculator(double weight, double height)
        {
            return weight / (height * height);
        }
    }
    //using System;

    //namespace SimpleBMICalculator
    //{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine("Welcome to the Simple BMI Calculator!");
    //            Console.WriteLine("------------------------------------");

    //            // Input weight in kilograms
    //            Console.Write("Enter your weight (in kilograms): ");
    //            double weight = double.Parse(Console.ReadLine());

    //            // Input height in meters
    //            Console.Write("Enter your height (in meters): ");
    //            double height = double.Parse(Console.ReadLine());

    //            // Calculate BMI
    //            double bmi = weight / (height * height);

    //            // Display the result
    //            Console.WriteLine("------------------------------------");
    //            Console.WriteLine($"Your BMI is: {bmi:F2}");

    //        }
    //    }
}



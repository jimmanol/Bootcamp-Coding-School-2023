using Microsoft.VisualBasic.FileIO;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Session_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // 1. Write a C# program to print Hello and your name in the same line. 

            HelloName helloName = new HelloName();
            Console.WriteLine(helloName.Get());
            Console.WriteLine();

            
            // 2. Write a C# program to print the result of the sum and division between two numbers.

            double numA = 7;
            double numB = 4;


            Console.WriteLine("The two numbers are: " +numA + " and " + numB);

            double sum = numA + numB;
            Console.WriteLine("The sum of the two numbers is: " + sum);

            double division = numA / numB;
            Console.WriteLine("The equation of the two numbers is: " + division);
            Console.WriteLine();

            
            // 3. Print the result of the specified operations

            double resOpA = -1 + (5*6); 
            Console.WriteLine("The result of the first operation is: " + resOpA);
            int resOpB = 38 + (5 % 7);
            Console.WriteLine("The result of the second operation is: " + resOpB);

            double a = 14;
            double b = (-18/7);
            double resOpC = a + b;
            Console.WriteLine("The result of the third operation is: " + resOpC);

            double resOpD = 2 + (13*6)/6 + Math.Sqrt(7);
            Console.WriteLine("The result of the fourth operation is: " + resOpD);

            double operEnumA = Math.Pow(6 , 4) + Math.Pow(5, 7);
            double operEnumB = 9%4;
            double resOpE = operEnumA/operEnumB;
            Console.WriteLine("The result of the fifth operation is: " + resOpE);
            Console.WriteLine();

            
            // 4. Print the gender and age of a person in the required format.
            int age = 50;
            string gender = "male";
            Console.WriteLine("You are " + gender + " and look younger than " + age);
            Console.WriteLine();

            
            // 5. convert an integer representing seconds to other time measurement units.
            int secs = 45678;
            int mins = secs / 60;
            int hours = mins / 60;
            int days = hours / 24;
            int years = days / 365;
            Console.WriteLine(secs + " Seconds is:  " + mins + " Minutes,  " + hours + " Hours,  " +
                days + " Days, and " + years + " Years.");
            Console.WriteLine();


           /* // 6. remake program 5 using .NET libraries
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string str = time.ToString(@"hh\:mm\:ss\:fff");


            Console.WriteLine(); */





            
            // 7. convert celsius degrees to Kelvin and Fahrenheit.
            float celsius = 24;
            double kelvin = celsius + 273.15;
            float fahr = (9*celsius)/5 + 32;
            Console.WriteLine(celsius + " degrees celsius is: " + kelvin + " Kelvin and " + fahr + " in Fahrenheit.");







            Console.ReadLine();

        }
    }
}
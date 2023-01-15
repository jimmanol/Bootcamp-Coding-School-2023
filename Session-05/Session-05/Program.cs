using System;
using System.Diagnostics.CodeAnalysis;

namespace Session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1. Reverse a given string

            string name = "Dimitris Manolas";
            string revName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                revName = revName + name[i];
            }
            Console.WriteLine("1. My name in reverse is : {0}\r\n", revName);



            // 2. sum or product from 1 to user input

            Console.WriteLine("2. Input number range for sum or product (1 to n): ");
            string number = Console.ReadLine();
            int r = Convert.ToInt32(number);

            Console.WriteLine("Pick between: 1. Sum or 2. Product: ");
            string selection = Console.ReadLine();
            int s = Convert.ToInt32(selection);

            
            int prod = 1;
            if (s == 1)
            {
                int sum = r * (r + 1) / 2;
                Console.WriteLine("The sum of the the numbers from 1 to {0} is: {1}\r\n", r, sum);
            }
            if (s == 2)
            {
                for (int i = 1; i <= r; i++)
                {
                    prod *= i;
                }
                Console.WriteLine("The product of the the numbers from 1 to {0} is: {1}\r\n", r, prod);
            }



            // 3. All prime numbers from 1 to chosen number

            Console.WriteLine("3. Please enter the range for the prime number search: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            Console.WriteLine("The prime numbers from 1 to {0} are: ", n);
            for (int i = 2; i <= n; i++)
            {
                int count = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count = 0;
                        break;
                    }
                }
                if (count == 1)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("\r\n");


            //4. Multiply each element of one array to the elements of another and display the results in a third array.

            int[] arrA = { 2, 4, 9, 12 };
            int[] arrB = { 1, 3, 7, 10 };
            Console.WriteLine("4. The elements of the first two arrays are: ");
            foreach (int len in arrA)
            {
                Console.Write(len.ToString() + ", ");
            }
            Console.WriteLine("");
            foreach (int len in arrB)
            {
                Console.Write(len.ToString() + ", ");
            }

            int[] arrC = new int [ arrA.Length * arrB.Length ];

            for (int i = 0; i < arrA.Length; i++) {
                for (int j = 0; j < arrB.Length; j++) {
                    arrC[ (i*arrA.Length) + j] = arrA[i] * arrB[j];
                }
             }
            Console.WriteLine("\r\nThe array produced: ");
            foreach (int len in arrC)
            {
                Console.Write(len.ToString() + ", ");
            }
            Console.WriteLine("\r\n");




            // 5. Sort given Array of integers in ascending order

            int[] myArr = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Console.WriteLine("5. The initial array is:");
            foreach (int num in myArr)
            {
                Console.Write(num.ToString() + ", ");
            }
            Console.WriteLine("");

            for (int i = 0; i < myArr.Length - 1; i++)
            {
                for (int j = 0; j < myArr.Length - (1 + i); j++)
                {
                    if (myArr[j] > myArr[j + 1])
                    {
                        int temp = myArr[j + 1];
                        myArr[j + 1] = myArr[j];
                        myArr[j] = temp;
                    }
                }
            }
            Console.WriteLine("The given array sorted in ascending order: ");
            foreach (int num in myArr)
            {
                Console.Write(num.ToString() + ", ");
            }


            Console.ReadLine();
        }
    }
 }

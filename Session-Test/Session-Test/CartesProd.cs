using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class CartesProd
    {
        public int[] CartProd() {
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
            Console.WriteLine("\r\nThe array produced: ");

            int[] arrC = new int[arrA.Length * arrB.Length];

            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    arrC[(i * arrA.Length) + j] = arrA[i] * arrB[j];
                }
            }
            return arrC;

        }
    }
}

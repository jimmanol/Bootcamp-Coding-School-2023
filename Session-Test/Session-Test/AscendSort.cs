using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Test
{
    internal class AscendSort
    {
        public int[] BubbleSort() {
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
            return myArr;

        }
    }
}

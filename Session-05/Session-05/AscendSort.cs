using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class AscendSort
    {
        public int[] BubbleSort(int[] myArr) {
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
            return myArr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class CartesProd
    {
        public int[] CartProd(int[] arrA, int[] arrB) {
            
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

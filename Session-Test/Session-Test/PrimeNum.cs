using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class PrimeNum
    {
        public void NumPrime(int n) {
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
                    Console.Write("{0}, ", i);
                }
            }
            
        }
    }
}

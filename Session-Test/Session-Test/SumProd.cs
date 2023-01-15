using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Session_Test
{
    internal class SumProd
    {
        
        
        public int Summary(int r){
            int sum = r * (r + 1) / 2;
            return sum;
        }


        public double Product(int r){
            double prod = 1;
            for (int i = 1; i <= r; i++)
            {
                prod *= i;
            }
            return prod;
        }
               
     }
            
}
         

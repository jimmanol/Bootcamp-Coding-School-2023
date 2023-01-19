using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class Subtraction {
        public double Do(string? x, string? y) {
            double ret = 0;
            if (x != null && y != null) {
                ret = Convert.ToInt32(x) - Convert.ToInt32(y);
            }
            return ret;
        }
    }
}


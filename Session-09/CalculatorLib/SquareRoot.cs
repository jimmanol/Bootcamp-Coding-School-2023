using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class SquareRoot {
        public double Do(string? x) {
            double ret = 0;
            if (x != null) {
                ret = Math.Sqrt(Convert.ToInt32(x));
            }
            return ret;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class SquareRoot {
        public double Do(double? x) {
            double ret = 0;
            if (x != null) {
                ret = Math.Sqrt(x.Value);
            }
            return ret;
        }

    }
}

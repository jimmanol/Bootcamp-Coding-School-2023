using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class Subtraction {
        public double Do(double? x, double? y) {
            double ret = 0;
            if (x != null && y != null) {
                ret = x.Value - y.Value;
            }
            return ret;
        }
    }
}


namespace CalculatorLib {
    public class Addition {
       public double Do(double? x, double? y) {
            double ret = 0;
            if (x != null && y != null) {
                    ret = x.Value + y.Value;
                }
            return ret;
            }
        }
}
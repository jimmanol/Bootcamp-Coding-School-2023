namespace CalculatorLib {
    public class Addition {
       public double Do(string? x, string? y) {
            double ret = 0;
            if (x != null && y != null) {
                    ret = Convert.ToInt32(x) + Convert.ToInt32(y);
                }
            return ret;
            }
        }
}
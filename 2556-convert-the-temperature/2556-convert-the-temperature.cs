public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double k = celsius + 273.15;
        double f = celsius * 1.80 + 32;
        double[] res = {k, f};
        return res;

    }
}
using System;
namespace DelegatesEventsLinq
{
    public class Sumator
    {
        public event Func<double, double, double> SumsHandler;
        public double CalculateAllSums(double x, double y)
        {
            double result = 0;
            var allSums = SumsHandler?.GetInvocationList();
            foreach (Func<double, double, double> sum in allSums)
            {
                result += sum(x, y);
            }

            return result;
        }
    }
}

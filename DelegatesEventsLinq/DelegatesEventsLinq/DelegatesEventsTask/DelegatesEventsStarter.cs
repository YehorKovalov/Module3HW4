using System;

namespace DelegatesEventsLinq
{
    public class DelegatesEventsStarter : IStarter
    {
        public void Run()
        {
            var sumator = new Sumator();
            const int sumsAmount = 2;
            for (int i = 0; i < sumsAmount; i++)
            {
                sumator.SumsHandler += Sum;
            }

            const double xTest = 3.5;
            const double yTest = 2.5;
            var result = Handler<double>.HandleFunc(
                () => sumator.CalculateAllSums(xTest, yTest));
            Console.WriteLine($"{sumsAmount}*({xTest} + {yTest}) = {result}");
        }

        private double Sum(double x, double y) => x + y;
    }
}

using System;

namespace DelegatesEventsLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IStarter starter = new LinqStarter();
            starter.Run();

            starter = new DelegatesEventsStarter();
            starter.Run();
        }
    }
}

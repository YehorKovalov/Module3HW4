using System;

namespace DelegatesEventsLinq
{
    public abstract class Handler<T>
    {
        public static T HandleFunc(Func<T> action)
        {
            var result = default(T);
            try
            {
                result = action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}

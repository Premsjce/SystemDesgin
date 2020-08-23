namespace VendingMachine
{
    /// <summary>
    /// Generic Utility Class to hold two objects
    /// </summary>
    /// <typeparam name="T1">First Object</typeparam>
    /// <typeparam name="T2">Secod Object</typeparam>
    public class Bucket<T1,T2>
    {
        public T1 First { get; }
        public T2 Second { get; }

        public Bucket(T1 f, T2 s)
        {
            First = f;
            Second = s;
        }
    }
}

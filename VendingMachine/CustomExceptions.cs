using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class NotFullPaidException : Exception
    {
        public NotFullPaidException(string message) : base(message)
        {

        }
    }

    public class NotSufficientChangeException : Exception
    {
        public NotSufficientChangeException(string message) : base (message)
        {

        }
    }

    public class SoldOutException : Exception
    {
        public SoldOutException(string message) : base(message)
        {

        }
    }
}

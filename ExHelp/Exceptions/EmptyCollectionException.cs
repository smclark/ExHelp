using System;

namespace ExHelp.Exceptions
{
    /// <summary>
    /// Exception to handle an empty collection i.e., a List or a Dictionary.
    /// </summary>
    public class EmptyCollectionException : Exception
    {
        public EmptyCollectionException()
        {
            
        }

        public EmptyCollectionException(string message) : base(message)
        {
            
        }

        public EmptyCollectionException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
    }
}

using System;
using System.Runtime.Serialization;

namespace RaspberryPi.Gpio.Exceptions
{
    [Serializable]
    public class OsVersionMismatchException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public OsVersionMismatchException()
        {
        }

        public OsVersionMismatchException(string message) : base(message)
        {
        }

        public OsVersionMismatchException(string message, Exception inner) : base(message, inner)
        {
        }

        protected OsVersionMismatchException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
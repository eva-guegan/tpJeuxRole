using System;
using System.Runtime.Serialization;

namespace tpJeuxRole
{
    internal class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
            //Console.WriteLine("Une exception c'est produite \n");
        }

        public MyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
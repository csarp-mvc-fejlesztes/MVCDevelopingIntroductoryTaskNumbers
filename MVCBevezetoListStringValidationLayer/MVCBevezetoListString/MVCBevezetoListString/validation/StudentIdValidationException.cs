using System;
using System.Runtime.Serialization;

namespace MVCBevezetoListString.validation
{
    [Serializable]
    internal class StudentIdValidationException : Exception
    {
        public StudentIdValidationException()
        {
        }

        public StudentIdValidationException(string message) : base(message)
        {
        }

        public StudentIdValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StudentIdValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
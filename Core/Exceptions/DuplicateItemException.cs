using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Core.Exceptions
{
    public class DuplicateItemException:ApplicationException
    {
        public DuplicateItemException() : base()
        {

        }

        public DuplicateItemException(string message):base(message)
        {

        }
        
        public DuplicateItemException(string message, Exception innerException):base(message, innerException)
        {

        }

        protected DuplicateItemException(SerializationInfo info, StreamingContext context): base (info, context)
        {

        }
    }
}

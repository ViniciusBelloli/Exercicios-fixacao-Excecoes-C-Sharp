using System;

namespace Teoria2.Entities.Exceptions
{
   class DomainException : ApplicationException
   {
      public DomainException(string message) : base(message)
      {
      }
   }
}
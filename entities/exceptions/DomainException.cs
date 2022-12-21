using System;

namespace nelio_dotnet.Entities.Exceptions
{
  class DomainException : ApplicationException
  {
    public DomainException(string message) : base(message)
    {
    }
  }
}

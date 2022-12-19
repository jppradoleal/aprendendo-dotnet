using System;

namespace nelio_dotnet.Entities
{
  class Client
  {
    public string name { get; set; }
    public string email { get; set; }
    public DateTime birthDate { get; set; }

    public override string ToString()
    {
      return $"{this.name} ({this.birthDate.ToString("dd/MM/yyyy")}) - {this.email}";
    }
  }
}
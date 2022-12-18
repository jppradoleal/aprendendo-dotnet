namespace nelio_dotnet
{
  class Student
  {
    public string Name { get; private set; }
    public string Email { get; private set; }

    public Student(string Name, string Email)
    {
      this.Name = Name;
      this.Email = Email;
    }

    public override string ToString()
    {
      return $"{this.Name}, {this.Email}";
    }
  }
}
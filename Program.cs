using System;
using System.Collections.Generic;

namespace nelio_dotnet
{
  class Pessoa
  {
    public string nome;
    public int idade;

    public Pessoa(string nome, int idade)
    {
      this.nome = nome;
      this.idade = idade;
    }


  }
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa[] pessoas = new Pessoa[2];
      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine($"Dados do {i + 1}º funcionário");
        Console.Write("Nome: ");
        string name = Console.ReadLine();
        Console.Write("Idade: ");
        int age = int.Parse(Console.ReadLine());
        pessoas[i] = new Pessoa(name, age);
      }

      Pessoa older = pessoas[0];

      if (pessoas[1].idade > older.idade)
      {
        older = pessoas[1];
      }

      Console.WriteLine($"Pessoa mais velha: {older.nome}");
    }
  }
}

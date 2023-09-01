using System;
class Dias_na_terra {
  static void Main() {
    string nome;
    int idade, dias;
    
    Console.WriteLine("insira o seu nome");
    nome = Console.ReadLine();
    Console.WriteLine($"Olá {nome}, insira sua idade");
    idade = int.Parse(Console.ReadLine());

    dias = idade * 365;
    
    Console.WriteLine($"{nome}, seus dias de vida na terra é {dias}");

  }
}

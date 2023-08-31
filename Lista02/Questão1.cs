using System;
class Media_Postos {
  static void Main() {
    string nome;
    float pp1, pp2, pp3, media;
    
    Console.WriteLine("insira o seu nome:");
    nome = Console.ReadLine();
    Console.WriteLine("insira o preço do primeiro posto:");
    pp1 = float.Parse(Console.ReadLine());
    Console.WriteLine("insira o preço do segundo posto:");
    pp2 = float.Parse(Console.ReadLine());
       Console.WriteLine("insira o preço do terceiro posto:");
    pp3 = float.Parse(Console.ReadLine());
    
    media = (pp1 + pp2 + pp3)/3;
    
    Console.WriteLine($"{nome}, a média dos três postos é:{media}");

  }
}

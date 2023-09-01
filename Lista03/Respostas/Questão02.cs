using System;
class ordem_ascendente {
  static void Main() {
    int numero1, numero2;
    //entrada de dados
    Console.WriteLine("Escreva um numero");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Escreva um numero");
    numero2 = int.Parse(Console.ReadLine());
    
    //saida
    if (numero1 < numero2) {
        Console.WriteLine($"{numero1}, {numero2}");
    }
    else{
        Console.WriteLine($"{numero2}, {numero1}");
    }    
  }
}

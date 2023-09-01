using System;
class maior {
  static void Main() {
    int numero1, numero2, numero3;
    //entrada de dados
    Console.WriteLine("Escreva um numero");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Escreva um numero");
    numero2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Escreva um numero");
    numero3 = int.Parse(Console.ReadLine());
    
    //saida
    if (numero1 > numero2 & numero1 > numero3) {
        Console.WriteLine($"{numero1}");
    }
    else{
        if (numero2 > numero1 & numero2 > numero3) {
            Console.WriteLine($"{numero2}");
    }
        else{
            Console.WriteLine($"{numero3}");
    }    
    }    
  }
}

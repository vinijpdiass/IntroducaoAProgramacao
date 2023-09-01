using System;
class par_ou_impar {
  static void Main() {
    int numero;
    //entrada de dados
    Console.WriteLine("Escreva um numero");
    numero = int.Parse(Console.ReadLine());
    
    //saida
    if ((numero%2 == 0)) {
        Console.WriteLine($"o numero {numero} é par");
    }
    else{
        Console.WriteLine($"o numero {numero} é impar");
    }    
  }
}

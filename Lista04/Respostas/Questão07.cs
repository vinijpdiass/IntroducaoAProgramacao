using System;
class questao5 {
  static void Main() {
    int numeros, i;  
    int sequencia = 1, soma = 1, sequencia2 = 0;
    Console.WriteLine("escreva a quantidade de numeros da sequencia de Fibonacci que vc deseja saber");
    numeros = int.Parse(Console.ReadLine());
    for (i = 1; i <= numeros; i++){
        
        Console.WriteLine(soma);        
        soma = sequencia + sequencia2;
        sequencia2 = sequencia;
        sequencia = soma;
        
    }
    
  }
}

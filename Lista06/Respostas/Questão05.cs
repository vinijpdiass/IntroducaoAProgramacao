using System;
class HelloWorld {
  static void Main() {
    int i = 0, N = 0, posicao = 0;
    int[] vetor = new int[10];
    
    for(i = 0; i < 10; i++){
        Console.WriteLine($"digite o {i + 1}° elemento do vetor");
        vetor[i] = int.Parse(Console.ReadLine());
    }
    
    Console.WriteLine("digite um numero inteiro");
    N = int.Parse(Console.ReadLine());
    
    for (i = 0; i <= 10; i++){
        if(N == vetor[i]){
            posicao = i;
            Console.WriteLine($"N está presente no vetor e sua posição é {posicao}");
            break;
        }
    }
    if(posicao != i){
        Console.WriteLine("N não está presente no vetor");
    }
  }
}

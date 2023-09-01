using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("digite uma sequencia de numeros\npara parar digite 0");
    int i = 1, j = 0, numero = 0, posicao = 0;
    int maior = 0;
    int[] sequencia = new int[1000];
    while (i != 0){
        numero = int.Parse(Console.ReadLine());
        
        if(numero == 0){
            break;
        } else if(numero > maior){
            maior = numero;
            posicao = i;
        }
        sequencia[i] = numero;
        i++;
    }
    Console.WriteLine($"Para uma seqüência digitada pelo usuário de {i} valores.");
    
    for(j = 0; j != i; j++){
    Console.Write("{0}\t", sequencia[j]);
    }
    
    Console.WriteLine($"\nO maior numero é {maior} e sua posição é {posicao}");
    
    
  }
}

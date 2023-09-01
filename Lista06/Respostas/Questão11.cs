using System;
class HelloWorld {
  static void Main() {
    int[,] A = new int[4,4];
    int i = 0, j = 0, soma = 0;
    for (i = 0; i < 4; i++){
        for (j = 0; j < 4; j++){
            Console.WriteLine($"escreva o numero da coluna {j + 1} na linha {i + 1}");
            A[i, j] = int.Parse(Console.ReadLine());
        }
    }
    
    for (i = 0; i < 4; i++){
        for (j = 0; j < 4; j++){
            if(i == j){
                soma = soma + A[i, j];
            }
        }   
    }
  
    Console.WriteLine($"A soma da diagonal da matriz é {soma}");  
  }
}

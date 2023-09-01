using System;
class HelloWorld {
  static void Main() {
    int[,] matriz = new int[3,5];
    //Random rnd = new Random();
    int i = 0, j = 0, X = 0, procura = 0;
    for (i = 0; i < 3; i++){
        for (j = 0; j < 5; j++){
            Console.WriteLine($"escreva o numero da coluna {j + 1} na linha {i + 1}");
            matriz[i, j] = int.Parse(Console.ReadLine());//aleatorio (para teste rapido)rnd.Next(100); 
        }
    }
    Console.WriteLine("escreva o numero que deseja procurar na matriz");
    X = int.Parse(Console.ReadLine());
    
    for (i = 0; i <3; i++){
        for (j = 0; j <5; j++){
            if(X == matriz[i,j]){
                Console.WriteLine($"o numero foi encontrado na {j + 1}° coluna na {i + 1}° linha da matriz");
                break;
            }else{
                procura++;
            }
        }
    }
    if(procura >= 15){
        Console.WriteLine("o numero não foi encontrado na matriz");
    }
  }
}

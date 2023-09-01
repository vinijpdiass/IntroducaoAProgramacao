using System;
class HelloWorld {
  static void Main() {
    int[,] z = new int[3,4];
    int i = 0, j = 0, X = 0, procura = 0, menor = 100000, maior = 0;
    for (i = 0; i < 3; i++){
        for (j = 0; j < 4; j++){
            Console.WriteLine($"escreva o numero da coluna {j + 1} na linha {i + 1}");
            z[i, j] = int.Parse(Console.ReadLine());
            if(z[i,j]> maior){
                maior = z[i,j];
            }
            if(z[i,j] < menor){
                menor = z[i,j];
            }
        }
    }
    
    for (i = 0; i <3; i++){
        for (j = 0; j <4; j++){
            if(maior == z[i,j]){
                Console.WriteLine($"o maior numero é {maior} e foi encontrado na {j + 1}° coluna na {i + 1}° linha da matriz");
                break;
            }
        }
    }
    for (i = 0; i <3; i++){
        for (j = 0; j <4; j++){
            if(menor == z[i,j]){
                Console.WriteLine($"o menor numero é {menor} e foi encontrado na {j + 1}° coluna na {i + 1}° linha da matriz");
                break;
            }
        }
    }
  }
}

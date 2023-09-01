using System;
class HelloWorld {
  static void Main() {
    int[] vet1 = new int[10];// para teste rapido {1,3,5,7,9,11,13,15,17,19};
    int[] vet2 = new int[10];//{2,4,6,8,10,12,14,16,18,20};
    int[] vet3 = new int[20];
    int i = 0, j = 0, i2 = 0, i3 = 1;
    for(i = 0; i < 10; i++){
      Console.WriteLine($"Escreva o elemento {i+1} do primeiro vetor");
      vet1[i] = int.Parse(Console.ReadLine());
      for(j = 0; j < 10; j++){
        if(vet1[i] < vet1[j]){
          Console.WriteLine("escreva um numero maior que o elemento anterior");
          vet1[i] = int.Parse(Console.ReadLine());
        }            
      }
            
    }
    for(i = 0; i < 10; i++){
      Console.WriteLine($"Escreva o elemento {i+1} do segundo vetor");
      vet2[i] = int.Parse(Console.ReadLine());
      for(j = 0; j < 10; j++){
        if(vet2[i] < vet2[j]){
          Console.WriteLine("escreva um numero maior que o elemento anterior");
          vet1[i] = int.Parse(Console.ReadLine());
        }            
      }
            
    }
    for(i = 0; i <= 9; i++){
      int v1 = vet1[i];
      vet3[i2] = v1;
      int v2 = vet2[i];
      vet3[i3] = v2;
      i2+=2;
      i3+=2;
    }
    for(i = 0; i < 20; i++){
      Console.Write(vet3[i]);
    }
  }
}

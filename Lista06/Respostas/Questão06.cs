using System;
class HelloWorld {
  static void Main() {
    int[] vet1 = new int[10];//{1,3,3,7,9,9,13,15,15,19};
    int[] vet2 = new int[10];
    int i = 0;
    for(i = 0; i < 10; i++){
      Console.WriteLine($"Escreva o {i+1}° elemento  do primeiro vetor");
      vet1[i] = int.Parse(Console.ReadLine());
    }
    for(i = 0; i < 10; i++){
      if(i == 0){
        vet2[i] = vet1[i];
      }else{
        for(int i2 = i; i2 >= 0; i2--){
            if(vet1[i] != vet1[i-1]){
                vet2[i] = vet1[i];
            }
        }
      }
    }
    Console.WriteLine("A sequencia do primeiro vetor é:");
    for(i = 0; i < 10; i++){
        Console.Write("{0}\t", vet1[i]);
    }
    //eu só consegui substituir o numero repetido por 0
    //então na hora de imprimir eu resolvi ignioralos e imprimir a ordem certa
    Console.WriteLine("\nA sequencia do segundo vetor é:");
    for(i = 0; i < 10; i++){
        if(vet2[i] == 0){
            continue;
        }else{
        Console.Write("{0}\t", vet2[i]);
        }    
    }
  }
}

using System;
class HelloWorld {
  static void Main() {
    float[] salarios  = new float[50];
    float soma = 0, media = 0, quantidade = 0;
    int i = 0;
    for(i = 0; i < 50; i++){
        Console.WriteLine($"Escreva o salario do {i+1}° funcionario");
        salarios[i] = float.Parse(Console.ReadLine());
        soma = soma + salarios[i];
    }
    media = soma/i;  
    for(i = 0; i < 50; i++){
        if (salarios[i] > media){
            quantidade++;
        }
    }     
    Console.WriteLine($"A quantidade de salários maiores que a média são: {quantidade}");
  }
}

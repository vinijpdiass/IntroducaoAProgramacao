using System;
class questao5 {
  static void Main() {
    int impares = 0, pares = 0;
    float numero = 0;  
    
    Console.WriteLine("diga os numeros presentes no seu conjunto\npara parar de adicionar ao conjunto digite -1");
    
    while (numero != -1){
        Console.WriteLine("escreva um numero inteiro");
        numero = float.Parse(Console.ReadLine());
        
        if(numero == -1){
            break;
        }
        else if(numero % 2 == 0){
            pares++;
        }else{
            impares++;
        }
    }
    
    Console.WriteLine($"a quantidade de numeros pares é {pares}");
    Console.WriteLine($"a quantidade de numeros impares é {impares}");
    
  }
}

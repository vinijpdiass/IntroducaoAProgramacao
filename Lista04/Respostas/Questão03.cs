using System;
class questao3 {
  static void Main() {
    int menornumero = 100000;
    int numero = 100000;  
    
    Console.WriteLine("diga os numeros presentes no seu conjunto\npara parar de adicionar ao conjunto digite 0");
    
    while (numero != 0){
        Console.WriteLine("escreva um numero inteiro");
        numero = int.Parse(Console.ReadLine());
        
        if(numero == 0){
            break;
        }
        else if(numero < menornumero){
            menornumero = numero;
        }
    }
    
    Console.WriteLine($"o menor numero do conjunto é {menornumero}"); 
    
  }
}

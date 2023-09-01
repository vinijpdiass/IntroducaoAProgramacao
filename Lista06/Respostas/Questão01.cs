using System;
class HelloWorld {
  static void Main() {
    float[] numero  = new float[8];
    float produto = 1;
    int i = 0;
    Console.WriteLine("Escreva um numero");
    for ( i = 0; i < 8; i++){
        numero[i] = int.Parse(Console.ReadLine());
        
    }
    for ( i = 0; i < 8; i++){
    
        produto = produto * numero[i];
        
    }
    Console.WriteLine($"a multiplicação dos elementos é igual a {produto}");
  }
}

using System;
class lista4_questao2 {
  static void Main() {
    
    int N, i;
    int tabuada;
    
    Console.WriteLine("Digite o numero (N) do intervalo :");
    N = int.Parse(Console.ReadLine());
    
    for(i = 0 ; i <= 10; i++){
        
        tabuada = N * i;
          Console.WriteLine($"{N} x {i} = {tabuada}");
  }
 }
}

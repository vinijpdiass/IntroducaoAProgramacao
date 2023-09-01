using System;
class  SomaImpares{
  static void Main() {
    int a, b, i;
    int soma = 0;
    
    Console.WriteLine("insira um valor inteiro");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("insira um valor inteiro");
    b = int.Parse(Console.ReadLine());
    
    for(i = a; i <= b; i++)
        if(i % 2 != 0)
        {
            soma = soma + i;
            Console.WriteLine(soma);
        }
        
    Console.WriteLine($"a soma total dos impares é {soma}");  
  }
  
}

using System;
class HelloWorld {
  static double fatorial(double Base, double expoente){
    double calculo;
    calculo = Math.Pow(Base, expoente);
    return calculo;
  }
  static void Main() {
    double i, j;
    double resultado = 0;  
    i = 2;
    while( i <= 20){
        j=1;
        while (j <= 10){
            resultado = fatorial(i, j);
            Console.WriteLine($"{i} elevado a {j} é igual a {resultado}");        
            j++;
        }
        i++;
        
    }
        
    }
}

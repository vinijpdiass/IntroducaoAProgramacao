using System;
class HelloWorld {
    static void TROCA(int[] numero){
        Array.Sort(numero);
        foreach (int n in numero) Console.Write("{0}\t",n);
    }
  static void Main() {
    int[] numero  = new int[4];
    int i = 0;
    for(i = 0; i<4; i++){
        Console.WriteLine($"escreva um numero");
        numero[i] = int.Parse(Console.ReadLine());
    }
    TROCA(numero);
  } 
}

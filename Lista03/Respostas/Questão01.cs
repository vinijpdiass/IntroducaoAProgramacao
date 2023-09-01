using System;
class numero3025 {
  static void Main() {
    int numero, n1, n2, soma, produto;
    //testar com 2025 para resultado positivo
    //entrada de dados
    Console.WriteLine("Escreva um numero entre 1000 e 9999");
    numero = int.Parse(Console.ReadLine());
    
    //operações
    n1 = numero/100;
    n2 = numero%100;
    soma = n1 + n2;
    produto = soma * soma;
  
    //saida
    if (produto == numero) {
        Console.WriteLine("Esse numero possui a mesma propriedade que o 3025");
    }
    else{
        Console.WriteLine("Esse numero não possui a mesma propriedade que o 3025");
    }    
  }
}

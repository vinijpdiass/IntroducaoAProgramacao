using System;
class bolo_de_Dinheiro {
  static void Main() {
    int nota1, nota5, nota10, nota50, nota100, total;  
    Console.WriteLine("Quantas notas de um 1 tem no bolo?");
    nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantas notas de 5 reais tem no bolo?");
    nota5 = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantas notas de 10 reais tem no bolo?");
    nota10 = int.Parse(Console.ReadLine());    
    Console.WriteLine("Quantas notas de 50 reais tem no bolo?");
    nota50 = int.Parse(Console.ReadLine());    
    Console.WriteLine("Quantas notas de 100 reais tem no bolo?");
    nota100 = int.Parse(Console.ReadLine());
    
    if ((nota1>=0) & (nota5>=0) & (nota10>=0) & (nota50>=0) & (nota100>0)){
        total = nota1 + (nota5 * 5) + (nota10 * 10) + (nota50 * 50) + (nota100 * 100);
        Console.WriteLine($"tem {total} reis no bolo");  
    }else{
        if((nota1>=0) & (nota5>=0) & (nota10>=0) & (nota50>0)){
            total = nota1 + (nota5 * 5) + (nota10 * 10) + (nota50 * 50);
            Console.WriteLine($"tem {total} reis no bolo");
        }else{
            if((nota1>=0) & (nota5>=0) &(nota10>0)){
                total = nota1 + (nota5 * 5) + (nota10 * 10);
                Console.WriteLine($"tem {total} reis no bolo");
            }else{
                if((nota1>=0) & (nota5>0)){
                    total = nota1 + (nota5 * 5);
                    Console.WriteLine($"tem {total} reis no bolo");
                }else{
                    Console.WriteLine($"tem {nota1} reis no bolo");  
                }    
            }
        
        }
    }
  }
}

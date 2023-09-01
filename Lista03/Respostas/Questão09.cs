using System;
class notas {
  static void Main() {
    
    int dinheiro, nota1 = 0, nota5 = 0, nota10 = 0, nota50 = 0, nota100 = 0;
    
    Console.WriteLine("Digite o valor total do bolo de dinheiro: ");
    dinheiro = int.Parse(Console.ReadLine());
    
    if (dinheiro >= 100){
        nota100 = dinheiro / 100;
        nota50 = (dinheiro % 100) / 50;
        nota10 = ((dinheiro % 100) % 50) / 10;
        nota5 = (((dinheiro % 100) % 50) % 10) / 5;
        nota1 =((((dinheiro % 100) % 50) % 10) % 5) / 1;
    }else if (dinheiro >= 50 && dinheiro < 100){
        nota50 = dinheiro / 50;
        nota10 = ((dinheiro % 100) % 50) / 10;
        nota5 = (((dinheiro % 100) % 50) % 10) / 5;
        nota1 =((((dinheiro % 100) % 50) % 10) % 5) / 1;
    }else if (dinheiro >= 10 && dinheiro < 20){
        nota10 = dinheiro / 10;
        nota5 = (((dinheiro % 100) % 50) % 10) / 5;
        nota1 =((((dinheiro % 100) % 50) % 10) % 5) / 1;
    }else if (dinheiro >= 5 && dinheiro < 10){
        nota5 = dinheiro / 5;
        nota1 =((((dinheiro % 100) % 50) % 10) % 5) / 1;
    }else{ 
        nota1 = dinheiro / 1;
    }
    Console.WriteLine("As notas no bolo são: ");
    Console.WriteLine("Notas de 100 : " + nota100);
    Console.WriteLine("Notas de 50 : " + nota50);
    Console.WriteLine("Notas de 10 : " + nota10);
    Console.WriteLine("Notas de 5 : "+ nota5);
    Console.WriteLine("Moedas de 1 : " + nota1);
        
    
  }
}

using System;
class convercao {
  static void Main() {
    double real, dolar, libra, euro;
    int converterpara;
    Console.WriteLine("Insira o valor em real");
    real = double.Parse(Console.ReadLine());
    Console.WriteLine("Deseja converter para: 1-Dolar, 2-Libra, 3-Euro");
    converterpara = int.Parse(Console.ReadLine());
    
    switch(converterpara){
        case 1:
            dolar = real / 4.00;
            Console.WriteLine($"{dolar} dolares");
            break;
        case 2:
            libra = real / 6.15;
            Console.WriteLine($"{libra} libras");
            break;
        case 3:
            euro = real / 4.72;
            Console.WriteLine($"{euro} euros");
            break;
        default:
            Console.WriteLine("converção não disponivel"); 
            break;
    }
  }
}

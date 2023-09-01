using System;
class HelloWorld {
  static bool Data(int dia, int mes){
    if(dia <= 31 && mes <= 12){
        return true;
    }else{
        return false;
    }
  }
  static void Main() {
    int dia, mes, ano;  
    bool validacao;
    Console.WriteLine("Digite o dia");
    dia = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o mês");
    mes = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano");
    ano = int.Parse(Console.ReadLine());
  
    validacao = Data(dia, mes);
    
    if(validacao == true){
        Console.WriteLine("Data válida");
    }else{
        Console.WriteLine("Data inválida");
    }
  }
}

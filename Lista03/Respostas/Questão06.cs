using System;
class classificação {
  static void Main() {
    int idade;
    Console.WriteLine("Insira sua idade");
    idade = int.Parse(Console.ReadLine());
    
    if ((idade >= 8) && (idade <= 10)){
        Console.WriteLine("InfantilB");
    }
    else{
        if((idade >= 11) && (idade <= 13)){
            Console.WriteLine("JuvenilA");
        }
        else{
            if((idade >= 14) && (idade <= 17)){
                Console.WriteLine("JuvenilB");
            }
            else{
                if((idade > 18)){
                    Console.WriteLine("Sênior");
                }
                else{
                    Console.WriteLine("Idade sem classificação");
                }
            }
        }        
    }
  }
}

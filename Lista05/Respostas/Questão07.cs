using System;  
class questão 7
{  
    static bool confirmacoes(int numero){
         for(int d = 2; d <= numero/2; d++)
            {
             if(numero % d == 0){
                return false;
            }
        }return true;
    }   
    
    public static void Main()
{
	int n, numero, d, divisores;
	bool confirmacao;
	
    Console.Write("diga até que numero você deseja ir : ");
    numero = int.Parse(Console.ReadLine()); 	
  
    for(n = 1; n <= numero; n++)
       {
         divisores = 0;

         for(d = 2; d <= n/2; d++)
            {
             if(n % d == 0){
                divisores++;
                break;
            }
        }
        
         if(divisores == 0 && n != 1)
            Console.Write("{0} ",n);
    }
    confirmacao = confirmacoes(numero);
    Console.WriteLine(" ");
    if(confirmacao == true){
        Console.WriteLine($"{numero} é primo");
    }else{
        Console.WriteLine($"{numero} não é primo");
    }
  } 
}

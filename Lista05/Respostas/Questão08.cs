using System;
class HelloWorld {
    static float serie(int n){
        int j = 1;
        float resposta = 0;
        int i = 1;
        
        for (i = 1; i <= n; i++){
            if(i == 1){
                resposta = i/n;
            }else{
                if (i % 2 == 0){
                    resposta = resposta - (i/(n - j));
                    j++;
                }else{
                    resposta = resposta + (i/(n - j));
                    j++;
                }
            }
        }
        return resposta;
    }
    
    static void Main() {
        int n;
        float resposta=0;
        
        Console.WriteLine("Escreva um numero inteiro");
        n = int.Parse(Console.ReadLine());
        resposta = serie(n);
        Console.WriteLine(resposta);      

        
    }
}

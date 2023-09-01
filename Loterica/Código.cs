using System;
namespace ApostaLoteria{ 
public class cartao{
    
    public int IdCartao;
    public int QuantidadeAposta;
    public string nome;
    public cartao(string nome, int IdCartao, int QuantidadeAposta){
        this.IdCartao = IdCartao;
        this.QuantidadeAposta = QuantidadeAposta;
        this.nome = nome;
    }
    //Metodos
    public virtual int[] Aposta(){
        int[] numero  = new int[QuantidadeAposta];
        
        for (int i = 0; i < QuantidadeAposta; i++){
            Console.WriteLine($"Digite o {i+1}° numero apostado");
            numero[i] = int.Parse(Console.ReadLine());
        }
        return numero;
    }
    
}//cartao
public class Sorteio{
    public int QuantidadeAposta;


    public Sorteio (int QuantidadeAposta){
        this.QuantidadeAposta = QuantidadeAposta;
    }
    public virtual int [] sorteado(){
        Random random = new Random();
        int[] Resultado  = new int[2];

        for (int i = 0; i < QuantidadeAposta; i++){
           Resultado[i] = random.Next(100);
        }/*
        Resultado[0] = 1;
        Resultado[1] = 2;*/
        return Resultado;
    }
    public int acertos(int[] numero, int[] Resultado){
        int i, j, igual = 0;
        for(i = 0; i < QuantidadeAposta; i++){
            for(j = 0; j < QuantidadeAposta; j++){
                if(numero[i] == Resultado[j]){
                    igual++;
                }else{
                    continue;
                }
            }
        }
        return igual;
        
        
    }
    
}//Loterica
public class VamoApostar{
    public static void Main(){
        int[] numero;
        int[] resultado;
        int ID, QN, QNA = 0, igual = 0, ganhador = 0, Maior = 0;
        string nome, nomeganhador = "ninguem", repetir;
        
        do{
        Console.WriteLine ("Qual o seu nome?");
        nome =  Console.ReadLine (); 
        
        Console.WriteLine ("Qual o ID do cartão?");
        ID = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Qual a quantidade de numeros na aposta?");
        QN =  int.Parse(Console.ReadLine ());

        cartao jogador = new cartao(nome, ID, QN);
        
        Sorteio jogada = new Sorteio(QN);
        
        numero = jogador.Aposta();    
        resultado = jogada.sorteado();
        igual = jogada.acertos(numero, resultado);
            
        if (igual > Maior){
            QNA = QN;
            Maior = igual;
            ganhador = ID;
            nomeganhador = nome;
        }
        
        Console.WriteLine("Se deseja cadastrar outro jogador?(y = sim/n = não)");
        repetir =  Console.ReadLine (); 
        
        }while (repetir == "y"||repetir == "Y");
        
        Console.WriteLine($"Parabens {nomeganhador} você venceu!!!");
        Console.WriteLine($"seu cartão ganhador foi o de id : {ganhador}");
        Console.WriteLine($"Sua quantidade de acertos no cartão foi foi {Maior} de {QNA}");
        
    }//main

}//VamoApostar
    
}//ApostaLoteria

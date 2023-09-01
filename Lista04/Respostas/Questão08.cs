using System;
class shopping {
  static void Main() {
    int idade, i = 0, objetivo, quantidadesf = 0, quantidadesm = 0;
    int compras = 0, servicos = 0, lazer = 0, alimentacao = 0, totalobjetivo;
    float porcentagem;
    string nome, sexo;
    
    Console.WriteLine("Bem vindo ao shopping!\nPor favor responda nossa pesquisa!");
    Console.WriteLine("obs:para acabar com a pesquisa escreva fim ao inves de seu nome");
    
    while (i != 1){
        Console.WriteLine("escreva seu nome");
        nome = Console.ReadLine();
        if(nome == "fim"){
            break;
        }
        Console.WriteLine("escreva sua idade");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva seu sexo(masculino ou feminino)");
        sexo = Console.ReadLine();
        if(sexo == "masculino"){
            quantidadesm++;
        }else{
            quantidadesf++;
        }
        Console.WriteLine("escreva o objetivo da visita");
        Console.WriteLine("010 Compras\n020 Serviços (Banco, correio,etc.)\n030 Lazer (Cinema, jogos,etc.)\n040 Alimentação (restaurantes e lanchonetes)");
        objetivo = int.Parse(Console.ReadLine());
        
        if(objetivo == 010){
            compras++;
        }else if(objetivo == 020){
            servicos++;
        }else if(objetivo == 030){
            lazer++;
        }else if(objetivo == 040){
            alimentacao++;
        }
    }
    
    totalobjetivo = compras + servicos + lazer + alimentacao;
    porcentagem = (servicos * 100)/totalobjetivo;
    Console.WriteLine($"a porcentagem de pessoas que escolheu serviços é {porcentagem}%");
    
    if(quantidadesf > quantidadesm){
        Console.WriteLine("o numero de mulheres frequentando o shopping foi maior que o de homens");  
    }else{
        Console.WriteLine("o numero de homens frequentando o shopping foi maior que o de mulheres");  
    }

    
  }
}

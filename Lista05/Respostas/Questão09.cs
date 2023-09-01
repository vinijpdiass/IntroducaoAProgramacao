using System;
class HelloWorld {
   static void entrada(string[] nome, string[] sexo, float[] peso, float[] altura){
    float somap = 0, somaa=0, mediap = 0, mediaa= 0, sm = 0, sf = 0, maior = 0, maiora = 0;
    string maiorp = "a", maioral = "b", mediaps, mediaas;
    int i = 0;
    for(i = 0; i<10; i++){
        if(sexo[i] == "f"){
            somap = somap + peso[i];
        }
        if(sexo[i] == "m"){
            somaa = somaa + altura[i];
        }
        if(sexo[i] == "m"){
            sm++;
        }else{
            sf++;
        }
    }
    mediap = somap / sf;
    mediaa = somaa / sm;
    
    for(i = 0; i<10; i++){
        
        if(peso[i] > maior && (sexo[i] == "f")){
            maiorp = nome[i];
            maior = peso[i];
        }
        if(altura[i] > maiora && (sexo[i] == "m")){
            maioral = nome[i];
            maiora = altura[i];
        }
    }
    
    mediaps = Convert.ToString(mediap);
    mediaas = Convert.ToString(mediaa);

    string[] saidas = new string[4]{mediaps, mediaas, maiorp, maioral};
    Console.WriteLine($"a media da altura dos homens é {saidas[1]}\na media do peso das mulheres é {saidas[0]}\no homem mais alto é {saidas[3]}\na mulher mais gorda é {saidas[2]}");
  }
  static float entrada2(float peso){
        peso = float.Parse(Console.ReadLine());
        return peso;
  }
  static void Main() {
    string[] nome = new string[10];//{"a", "b", "c","d","f","g","h","i","j","k"};
    string[] sexo = new string[10];//{"f", "m", "m","m","m","f","f","f","m","f"};
    float[] altura  = new float[10];//{ 1.50f, 1.60f, 1.26f, 1.28f, 1.80f, 1.90f, 2f, 1.50f, 1.30f, 1.40f};
    float[] peso  = new float[10];//{ 40f, 60f, 26f, 28f, 80f, 90f, 90f, 50f, 80f, 40f};
    int i = 0;
    
    for(i = 0; i<10; i++){
        Console.WriteLine("escreva o nome, sexo, altura e peso da pessoa");
        nome[i] = Console.ReadLine();
        sexo[i] = Console.ReadLine();
        altura[i] = float.Parse(Console.ReadLine());
        peso[i] = float.Parse(Console.ReadLine());
    }
    entrada(nome, sexo, peso, altura);
  }
}

using System;
class diferença_de_datas{
  static void Main() {
    int dia_data1, dia_data2, mes_data1, mes_data2, ano_data1, ano_data2;
    int diferenca_ano, diferenca_mes, diferenca_dia;
    
    Console.WriteLine("escreva duas datas, uma em cada linha, onde o dia, o mês e o ano da segunda seja maior que a da primeira");
    
    //dia
    Console.WriteLine("escreva o dia da primeira data");
    dia_data1 = int.Parse(Console.ReadLine());
    Console.WriteLine("escreva o dia da segunda data");
    dia_data2 = int.Parse(Console.ReadLine());
    
    //mes
    Console.WriteLine("escreva o mes da primeira data");
    mes_data1 = int.Parse(Console.ReadLine());
    Console.WriteLine("escreva o mes da segunda data");
    mes_data2 = int.Parse(Console.ReadLine());  
    
    //ano
    Console.WriteLine("escreva o ano da primeira data");
    ano_data1 = int.Parse(Console.ReadLine());
    Console.WriteLine("escreva o ano da segunda data");
    ano_data2 = int.Parse(Console.ReadLine());
    
    //processamento de dados
    diferenca_ano = ano_data2 - ano_data1;
    diferenca_mes = (diferenca_ano * 12) + (mes_data2 - mes_data1);
    diferenca_dia = (diferenca_mes * 30) + (dia_data2 - dia_data1);
    
    //saida
    Console.WriteLine($"A diferença de anos entre as duas datas é {diferenca_ano}");
    Console.WriteLine($"A diferença de mês entre as duas datas é {diferenca_mes}");
    Console.WriteLine($"A diferença de dias entre as duas datas é {diferenca_dia}");
    }
}

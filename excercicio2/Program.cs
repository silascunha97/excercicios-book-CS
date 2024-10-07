/*
  Excercicios:36.
    Calcular a quantidade litros de combustível gasta em uma viagem, utilizando um automoval que faz 12km por litro.
  para  um cálculo, o usuario deve fornecer o tempo gasto na viagem e a velocidade média. Dessa forma, é possivel obter
  a distância percorrida com a fórmula DISTANCIA=TEMPO*VELOCIDADE. Tendo o valor da distancia, basta calcular a quantidade
  de litros de combústivel utilizada na viagem com a fórmu LITROS_USADOS = DISTANCIA/12. O Programa deve apresentar os valores
  da velocidade média, o tempo gasto, a distância percorrida e a quantidade litros utilizados na viagem. Trabalhe com valores reais.
  
  Tipos de dados inteiros:
  Double,
  Float,
  Long,
  Decimal.
  */

using System;
using System.Collections.Generic;

public class programa
{
    public static void Main()
    {
        System.Console.WriteLine("Olá Mundo!");
        Double viagem_primary = new Double();
        System.Console.WriteLine(viagem_primary);
    }
}

public class Carro
{
  public Double DISTANCIA, LITROS;
  public Double Tempo = 12;
  
  public Double bourn_power(){
    Console.WriteLine("Digite o tempo gasto na distancia: ");
    Double TEMP_DIST = Parse(Console.ReadLine());

    Console.WriteLine("Digite o tempo gasto na distancia: ");
    Double VELOCIDADE = Parse(Console.ReadLine());

    Double COMB_GAST=TEMPO*VELOCIDADE;



    return COMB_GAST;
  }
}
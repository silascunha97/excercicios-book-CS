using System;

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

public class Program
{
    public static void Main()
    {
        // Inicializa um objeto da classe Carro e executa o cálculo
        Carro viagem_primary = new Carro();
        viagem_primary.CalcularConsumo();
    }
}

public class Carro
{
    // Campos da classe
    public double CONSUMO = 12;

    // Construtor padrão
    public Carro()
    {
        // Inicialização padrão, se necessário
    }

    // Método para calcular o consumo de combustível
    public void CalcularConsumo()
    {
        Console.WriteLine("Digite o tempo gasto na viagem (em horas): ");
        double tempo = double.Parse(Console.ReadLine()); // Lê e converte o tempo

        Console.WriteLine("Digite a velocidade média (em km/h): ");
        double velocidade = double.Parse(Console.ReadLine()); // Lê e converte a velocidade

        // Calcula a distância percorrida
        double distancia = tempo * velocidade;

        // Calcula a quantidade de litros utilizada
        double litrosUsados = distancia / CONSUMO;

        // Exibe os resultados
        Console.WriteLine($"Velocidade média: {velocidade} km/h");
        Console.WriteLine($"Tempo gasto: {tempo} horas");
        Console.WriteLine($"Distância percorrida: {distancia} km");
        Console.WriteLine($"Combustível utilizado: {litrosUsados} litros");
    }
}

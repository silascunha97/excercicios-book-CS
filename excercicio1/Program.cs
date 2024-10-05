/* 
        Elabore um programa que efetue o cálculo de salário de um profissional horista.
    o programa deve solicitar as horas trabalhadas, o valor da hora o percentual de desconto
    para apresentar o salário bruto o total de desconto salário líquido execute o comando
    do projeto forneça nome para o projeto acione o botão aqui para se lembrar de uma das
    selecionada a sequência opcional. */
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite a quantidade de horas trabalhadas por dia: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor da hora trabalhada: ");
        double valorHora = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de dias trabalhados por semana: ");
        int diasTrabalhados = int.Parse(Console.ReadLine());

        // Cálculo do salário bruto mensal (considerando 4 semanas)
        double salarioBruto = horasTrabalhadas * valorHora * diasTrabalhados * 4;

        Console.WriteLine($"Seu salário bruto é: R$ {salarioBruto:F2}");

        Console.Write("Digite o percentual de desconto (INSS): ");
        double percentualDesconto = double.Parse(Console.ReadLine());

        // Cálculo do desconto
        double valorDesconto = salarioBruto * percentualDesconto / 100;

        // Cálculo do salário líquido
        double salarioLiquido = salarioBruto - valorDesconto;

        Console.WriteLine($"O valor do desconto é: R$ {valorDesconto:F2}");
        Console.WriteLine($"Seu salário líquido é: R$ {salarioLiquido:F2}");

        
    }
}

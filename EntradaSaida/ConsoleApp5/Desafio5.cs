using System;
using System.Data;

class Desafio5
{
    static void Main()
    {

        Console.Write("Digite quanto você ganha por hora: ");
        double vlrPorHr = double.Parse(Console.ReadLine());

        Console.Write("Digite quantas horas foram trabalhadas: ");
        int hrsTrabalho = int.Parse(Console.ReadLine());

        double salarioBruto = hrsTrabalho * vlrPorHr;

        double IR = salarioBruto * 0.11;
        double INSS = salarioBruto * 0.08;
        double Sindicato = salarioBruto * 0.05;

        double salarioLiquido = salarioBruto - IR - INSS - Sindicato;

        Console.WriteLine("Salário bruto: " + salarioBruto);
        Console.WriteLine("Valor desc IR: " + IR);
        Console.WriteLine("Valor desc INSS: " + INSS);
        Console.WriteLine("Valor desc Sindicato: " + Sindicato);
        Console.WriteLine("Salário líquido: " + salarioLiquido);

    }
}


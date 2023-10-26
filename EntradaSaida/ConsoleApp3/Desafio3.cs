using System;
using System.Data;

class Desafio2
{
    static void Main()
    {
        double salario = 500;

        Console.Write("Digite o nome do vendedor: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a quantidade de carros vendidos: ");
        int qtdeCarros = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor total vendido pela loja: ");
        double vlrTotal = double.Parse(Console.ReadLine());

        vlrTotal = vlrTotal * 0.05;

        double comissao = (qtdeCarros * 50) + vlrTotal;

        salario = salario + comissao;

        Console.WriteLine("-----------------");

        Console.WriteLine("Vendedor: " + nome);
        Console.WriteLine("Valor total de comissão: " + comissao);
        Console.WriteLine("Salário total do vendedor: " + salario);
    }
}


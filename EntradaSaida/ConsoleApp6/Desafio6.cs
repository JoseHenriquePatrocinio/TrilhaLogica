using System;
using System.Data;

class Desafio6
{
    static void Main()
    {

        Console.Write("Digite o tamanho da área a ser pintada: ");
        double area = double.Parse(Console.ReadLine());

        double qtdeLatas = area / 54;

        double valorTotal = qtdeLatas * 80; 

        Console.WriteLine("Quantidade de latas: " + qtdeLatas);
        Console.WriteLine("Valor total: " + valorTotal);

    }
}
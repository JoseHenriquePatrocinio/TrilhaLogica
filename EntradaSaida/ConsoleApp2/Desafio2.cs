using System;
using System.Data;

class Desafio2
{
    static void Main()
    {

        Console.Write("Digite o custo do item direto de fábrica: ");
        double VLC = double.Parse(Console.ReadLine());

        Console.Write("Digite a porcentagem de comissão do representante: ");
        double CR = double.Parse(Console.ReadLine()) / 100;
        double VC = VLC * CR;

        Console.Write("Digite a porcentagem da margem de lucro: ");
        double ML = double.Parse(Console.ReadLine()) / 100;
        double VM = VLC * ML;

        Console.Write("Digite a porcentagem de imposto: ");
        double GOV = double.Parse(Console.ReadLine()) / 100;
        double VG = VLC * CR * ML * GOV;

        double VF = VLC + VC + VM + VG;

        Console.WriteLine("Valor comissão: " + VC);
        Console.WriteLine("Valor margem de lucro: " + VM);
        Console.WriteLine("Valor impostos: " + VG);
        Console.WriteLine("Valor de venda: " + VF);


    }
}


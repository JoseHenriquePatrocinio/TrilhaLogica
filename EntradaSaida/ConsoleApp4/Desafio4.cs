using System;
using System.Data;
using System.Xml.Schema;

class Desafio2
{
    static void Main()
    {

        Console.Write("Digite quantas horas de atendimento: ");
        int horas = (int.Parse(Console.ReadLine()) * 60) * 60;

        Console.Write("Digite quantos minutos de atendimento: ");
        int minutos = (int.Parse(Console.ReadLine()) * 60) + horas;

        Console.Write("Digite quantos segundo de atendimento: ");
        int segundos = int.Parse(Console.ReadLine()) + minutos;

        Console.WriteLine("Tempo total em segundos: " + segundos);

    }
}


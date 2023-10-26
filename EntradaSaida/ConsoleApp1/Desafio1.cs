using System;
using System.Data;

class Desafio1
{
    static void Main()
    {

        Console.Write("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor de A: " + a);
        Console.WriteLine("Valor de B: " + b);
        Console.WriteLine("------------------");

        int c = b;
        b = a;
        a = c;

        Console.WriteLine("Valor de A invertido: " + a);
        Console.WriteLine("Valor de B invertido: " + b);

    }
}


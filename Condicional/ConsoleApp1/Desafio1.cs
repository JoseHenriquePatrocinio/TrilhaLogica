using System;
using System.Data;

class Desafio1
{
    static void Main()
    {

        Console.Write("Digite um numero de 1 a 12: ");
        int num = int.Parse(Console.ReadLine());

        if (num == 0 || num > 12)
            Console.WriteLine("Numero Inválido");
        else
            if (num == 1)
            Console.WriteLine("Janeiro");
        else if (num == 2)
            Console.WriteLine("Fevereiro");
        else if (num == 3)
            Console.WriteLine("Março");
        else if (num == 4)
            Console.WriteLine("Abril");
        else if (num == 5)
            Console.WriteLine("Maio");
        else if (num == 6)
            Console.WriteLine("Junho");
        else if (num == 7)
            Console.WriteLine("Julho");
        else if (num == 8)
            Console.WriteLine("Agosto");
        else if (num == 9)
            Console.WriteLine("Setembro");
        else if (num == 10)
            Console.WriteLine("Outubro");
        else if (num == 11)
            Console.WriteLine("Novembro");
        else
            Console.WriteLine("Dezembro");
    }
}
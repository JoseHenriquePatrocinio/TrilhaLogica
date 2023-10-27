using System;
using System.Data;

class Desafio2
{
    static void Main()
    {

        Console.Write("Digite o último número da placa: ");
        int num = int.Parse(Console.ReadLine());

        if (num == 0 || num == 5)
            Console.WriteLine("Não pode circular na segunda");
        else if (num == 1 || num == 6)
            Console.WriteLine("Não pode circular na terça");
        else if (num == 2 || num == 7)
            Console.WriteLine("Não pode circular na quarta");
        else if (num == 3 || num == 8)
            Console.WriteLine("Não pode circular na quinta");
        else
            Console.WriteLine("Não pode circular na sexta");

    }
}
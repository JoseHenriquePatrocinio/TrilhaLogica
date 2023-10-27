using System;
using System.Data;

class Desafio3
{
    static void Main()
    {

        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite um operador: ");
        string op = Console.ReadLine();

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado;

        if (op == "+")
            Console.WriteLine(resultado = num1 + num2);
        else if (op == "-")
           Console.WriteLine(resultado = num1 - num2);
        else if (op == "*")
           Console.WriteLine(resultado = num1 * num2);
        else if (num2 != 0 &&  op == "/")
          Console.WriteLine(resultado = num1 / num2);       
        else
            Console.WriteLine("Cannot divide by zero");
    }
}
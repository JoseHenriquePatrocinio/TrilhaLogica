using ConsoleApp4;
using System;
using System.Data;

class Desafio3
{
    static void Main()
    {

        Console.Write("Digite 1(Filme), 2(Série), 3(Documentário): ");
        int escolha = int.Parse(Console.ReadLine());  
        dto escolhas = new dto();

        if (escolha == 1)
        {
            escolhas.Categoria = "Filme";

            Console.Write("Digite 1(Drama), 2(Ação)");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                escolhas.Genero = "Drama";
                escolhas.Sugestao = "Ex Machina:Instinto Artificial";
            }

            else
            {
                escolhas.Genero = "Ação";
                escolhas.Sugestao = "Minority Report";
            }
        }
        else if(escolha == 2)
        {
            escolhas.Categoria = "Série";

            Console.Write("Digite 1(Suspense), 2(Ficção Cientifica)");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                escolhas.Genero = "Suspense";
                escolhas.Sugestao = "Black Mirror";
            }
            else
            {
                escolhas.Genero = "Ficção Cientifica";
                escolhas.Sugestao = "Better than us";
            }              
        }
        else
        {
            escolhas.Categoria = "Documentário";

            Console.Write("Digite 1(Tecnologia), 2(Biografia)");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                escolhas.Genero = "Tecnologia";
                escolhas.Sugestao = "Watson da IBM";
            }
            else
            {
                escolhas.Genero = "Biografia";
                escolhas.Sugestao = "O código Bill Gates";
            }                
        }

        Console.Clear();
        Console.WriteLine(escolhas.Categoria);
        Console.WriteLine(escolhas.Genero);
        Console.WriteLine(escolhas.Sugestao);

    }
}
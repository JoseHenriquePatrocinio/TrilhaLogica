class Desafio5
{
    static void Main()
    {

        Console.Write("Digite o valor da compra do produto: ");
        double preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a forma de pagamento: ");
        Console.Write("1(Cheque), 2(Crédito), 3(Débito), 4(Dinheiro)");
        int formaPgto = int.Parse(Console.ReadLine());

        double resultado;

        if (formaPgto == 1)
        {
            Console.Write("1(à vista), 2(à prazo)");
            formaPgto = int.Parse(Console.ReadLine());

            if (formaPgto != 1)
                Console.Write("Valor total da compra: " + (resultado = (preco * 0.05) + preco));
            else
                Console.Write("Valor total da compra: " + preco);
        }
        else if (formaPgto == 2)
        {
            Console.Write("1(à vista), 2(à prazo)");
            formaPgto = int.Parse(Console.ReadLine());

            if (formaPgto != 1)
            {
                Console.Write("Digite em quantas vezes deseja fazer: ");
                int xParcelas = int.Parse(Console.ReadLine());

                if (xParcelas > 10)
                    Console.Write("Número de parcelas inválido");
                else
                {
                    Console.WriteLine("Valor total da compra: " + (resultado = (preco * 0.05) + preco));
                    Console.Write("Valor da parcela: " + (resultado = resultado / xParcelas));
                }
            }
            else
                Console.Write("Valor total da compra: " + preco);
        }
        else if (formaPgto == 3)
            Console.Write("Valor total da compra: " + (resultado = preco - (preco * 0.05)));
        else
            Console.WriteLine("Valor total da compra: " + (resultado = preco - (preco * 0.1)));
    }
}
class Desafio1
{
    static void Main()
    {

        Console.Write("Digite 1 para iniciar: ");
        int num = int.Parse(Console.ReadLine());
        Console.Clear();

        string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

        for (int i = 0; i < 12; i++)
        {
            if (num != 0 || num < 12)
            {
                Console.Write("Digite um numero de 1 a 12: ");
                num = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(meses[num - 1]);
            }
            else
                Console.WriteLine("Valor Inválido");
        }
    }
}
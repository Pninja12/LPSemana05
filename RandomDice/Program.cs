using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Quantos dados?  -> ");
            string string_dados = Console.ReadLine();
            int lancamento = int.Parse(string_dados);
            int dado = 0;

            for (int i = 0; i < lancamento; i++)
            {
                dado = dado + rnd.Next(1, 7);
            }

            Console.Write($"O resultado é {dado}");
        }
    }
}

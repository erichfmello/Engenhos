using System;

namespace Teste001
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Escreva um número");
                number = int.Parse(Console.ReadLine());

                for (int i = 0; i < number; i++)
                {
                    if (i == 0)
                        continue;

                    if ((i + 1) % 3 == 0 || (i + 1) % 5 == 0)
                        sum += (i + 1);
                }

                Console.WriteLine($"Soma = {sum}");

                sum = 0;

                Console.WriteLine($"Deseja continuar (S ou N)?");
                if (Console.ReadLine().ToUpper() == "N")
                    exit = true;
            }
        }
    }
}

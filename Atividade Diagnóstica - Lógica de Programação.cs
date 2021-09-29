
using System;

namespace atividade_diagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                vetor[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.In.ReadLine());
            
            if(vetor.Contains(num))
            {
                Console.WriteLine($"O número {num} foi encontrado com sucesso!");
            }
            else
            {
                Console.WriteLine($"O número {num} não foi encontrado.");
            }

            # printa na tela se é par ou ímpar
            if(num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é par!");
            }
            else
            {
                Console.WriteLine($"O número {num} é ímpar!");
            }
            
        }
    }
}

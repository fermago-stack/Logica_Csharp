using System;

namespace Historico_de_compras
{
    // Desenvolva um programa que armazene o histórico total
    // de compras de 10 clientes e mostre o total gasto de cada cliente.

    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] compras = new double[10, 5];

            for (int i = 0; i < 10; i++)
            {
                double total = 0;

                Console.WriteLine($"\nCompras do Cliente {i + 1}:");

                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Valor da Compra {j + 1}: R$ ");
                    compras[i, j] = double.Parse(Console.ReadLine());

                    total += compras[i, j];
                }

                Console.WriteLine(
                    $"Total gasto pelo cliente {i + 1}: R$ {total:0.00}"
                );
            }

            Console.ReadKey();
        }
    }
}
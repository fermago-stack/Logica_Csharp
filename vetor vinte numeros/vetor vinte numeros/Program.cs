using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_vinte_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int[] pares = new int[20];
            int[] impares = new int[20];

            int p = 0, i = 0;

            for (int j = 0; j < numeros.Length; j++)
            {
                Console.Write($"Digite o numero {j + 1}: ");
                numeros[j] = int.Parse(Console.ReadLine());

                if (numeros[j] % 2 == 0) pares[p++] = numeros[j];
                else impares[i++] = numeros[j];

            }

            Console.WriteLine("\n Pares: ");
            for (int j = 0; j < p; j++) Console.WriteLine(pares[j] + "   ");

            for (int j = 0; j < i; j++) Console.WriteLine(impares[j] + "   ");


        }
    }
}








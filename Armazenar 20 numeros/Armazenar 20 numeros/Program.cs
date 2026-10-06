using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armazenar_20_numeros
{
    //"Crie um programa que armazene 20 numeros e separe-os em dois arrays: um com numeros pares e outro com numeros impares."


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[20];
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($" Digite vinte numeros {i + 1}:  ");
                numero[i] = int.Parse(Console.ReadLine());

                if (numero[i] % 2 == 0)

                    pares++;

                else

                    impares++;
            }
                Console.WriteLine($"\nQuantidade de números pares: {pares}");
                Console.WriteLine($"Quantidade de números ímpares: {impares}");




            

        }
    }
}

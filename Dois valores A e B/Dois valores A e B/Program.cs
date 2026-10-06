using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dois_valores_A_e_B
{ /*1- Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores,
  caso contrário devera multiplicar A por B.
 Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e imprimir seu valor na tela.*/

    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine(" Digite um valor para variavel A:   ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite um valor para variavel B:   ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {

                c = a + b;
                Console.WriteLine(" A soma das variaveis é:  " + c);

            }

            else
            {

                c = a * b;
                Console.WriteLine(" A multiplicação das variaveis é:  " + c);

            }

            }
        }
    }


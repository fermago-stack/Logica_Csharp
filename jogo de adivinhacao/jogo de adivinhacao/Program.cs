using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_adivinhacao
{
    internal class Program
    { /* simular um jogo de adivinhação: o jogador 1 escolhe um numero entre 1 e 10;
         o jogador 2 insere numeros na tentativa de acertar o numero escolhido pelo jogador 1.
         Quando ele acertar, o algoritmo deve informar que ele acerrtou o numero x ( escolido pelo jogador 1)
         em x tentativas ( quantidade de tentativas do jogador 2).*/

        static void Main(string[] args)
        {
            int numeroEscolhido;
            int tentativa;
            int tentativas = 0;

            Console.WriteLine(" O jogado 1 escolhe um numero de 1 a 10:   ");
            numeroEscolhido = int.Parse(Console.ReadLine());

            Console.Clear();

        

            do
            {
                Console.Write("O jogado 2 irá adivinhar o numero do 1 jogador, digite numero de 1 a 10:   ");
                tentativa = int.Parse(Console.ReadLine());

                tentativas++;

                if (tentativa != numeroEscolhido)
                {
                    Console.WriteLine("Você errou! Tente novamente.");
                }

            } while (tentativa != numeroEscolhido);

            Console.WriteLine();
            Console.WriteLine("Parabéns! Você acertou o número   " + numeroEscolhido+ " em " +tentativas+ " tentativas.");

            Console.ReadKey();


        }
    }
}

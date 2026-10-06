using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrica
{
    internal class Program
    { /* Uma fábrica tem uma linha de produção capaz de produzir 40 peças/dia.
         Um funcionario controla a qualidade, cadastrando o mumero de peçãs e
         seu estado (aprovado ou reprovado). Criar um programa para cadastrar o
         controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.*/

        static void Main(string[] args)
        {
            int contador, reprovadas, aprovadas, numPecas;
            string estado;
            contador = 1;
            reprovadas = 0;
            aprovadas = 0;

            while (contador <= 40)
            {
                Console.WriteLine(" Digite o numero da  " + contador + " peca");
                numPecas = int.Parse(Console.ReadLine());

                Console.WriteLine(" digite se a peça foi esta aprovada ou reprovada( a para aprovada / r para reprovada):  ");
                estado = Console.ReadLine();

                if (estado == "a")
                {
                    aprovadas++;
                }

                else
                {
                    reprovadas++;
                }

                contador++;

            }

            Console.WriteLine(" Total de peças  aprovadas:  " + aprovadas);
            Console.WriteLine(" Total de peças reprovadas:  " + reprovadas);


        }


    }
}

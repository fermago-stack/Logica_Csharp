using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_Vinho
{
    internal class Program
    {
        /* Contrua um programa que permita fazer o levantamento do estoque de vinhos de uma adega, tendo como daos de entrada
        tipos de vinho,sendo "t" para tinto e "b" para branco. Como a quantidade de vinho é desconhecida, utilize a letra "f " 
        para finalizar. Após finalizar o programa de ve mostrar a quantidade de vinho na adega. */

        static void Main(string[] args)
        {

            int vinhosTintos = 0;
            int vinhosBrancos = 0;
            int contador;
            string vinhos;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔════╝
███████║██║░░██║█████╗░░██║░░██╗░███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║╚█████╗░
██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║░╚═══██╗
██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝██████╔╝
╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();
            for (contador = 1; contador > 0; contador++)
            {

                Console.WriteLine("Digite 't' para Tinto, 'b' para Branco ou 'f' para Finalizar.\n");
                vinhos = Console.ReadLine();

                if (vinhos == "b")
                {
                    vinhosBrancos++;
                }
                if (vinhos == "t")
                {
                    vinhosTintos++;
                }
                Console.Clear();
                if (vinhos == "f")
                {
                    Console.WriteLine("O total de vinhos brancos em estoque são:  " + vinhosBrancos + "\ne o de vinho tintos são:  " + vinhosTintos);
                    break;



                }



            }
        }
    }
}



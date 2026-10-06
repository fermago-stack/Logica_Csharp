using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastor_de__bandas
{
    internal class Program
    {
        /* 
          se / enquanto / para /caso 
          if / while     for / switch
         
        Crie um programa que cadastro de Albuns 
         
        */
        static void Main(string[] args)
        {

            int Opcao = 0;

            while (Opcao != 4)
            {
                Console.Clear(); // Limpa a tela do console
                Console.ForegroundColor = ConsoleColor.Yellow; // Define a cor do texto como verde
                Console.WriteLine(@"

░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░ ");

                Console.ResetColor(); // Restaura a cor padrão do console
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastro Album da Banda");
                Console.WriteLine("2 - Cadastro Album do Artista");
                Console.WriteLine("3 - Cadastrar musica");
                Console.WriteLine("4 - sair do Programa ");
                Console.WriteLine(" ------>");
                Console.ResetColor();

                Opcao = int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" Saindo do Program !!! Tchau Tchau !!    :");
                        break;

                }





            }
        }
    }
}

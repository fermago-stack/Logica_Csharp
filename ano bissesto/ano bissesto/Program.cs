using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ano_bissexto
{
    /* 
           6. Ano bissexto
           Determine se um ano é bissexto. Um ano é bissexto se for divisivel por 4, mas por 100, a não 
           ser que seja divissivel por 400.
           . entrada: 2024
           . saída esperada: ano bissexto
           */
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.Write("Digite o ano:  ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("ano bisssexto");
            }

            else if (ano % 400 == 0)
            {
                Console.WriteLine("ano bissexto");
            }

            else
            {
                Console.WriteLine("não bissexto");
            }


        }
    }
}

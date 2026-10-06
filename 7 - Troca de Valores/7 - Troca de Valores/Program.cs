using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___valores_trocados
{
    /* 7- Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor 
de B por A e imprima na tela os valores*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            C = A;
            A = B;
            B = C;
            Console.Write("\n O valor de A é: " + A);

            Console.Write("\n O valor de B é: " + B);
            Console.ReadKey();
        }
    }
}

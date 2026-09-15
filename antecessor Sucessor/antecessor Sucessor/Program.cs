using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antecessor_Sucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, maior, menor;

            Console.Write(" Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());

            maior = n1 + 1;

            menor = n1 - 1;

            Console.Write(" O numero antecessor é:  " + menor);
            Console.Write(" \n O numero sucessor é:  " + maior);


        }
    }
}

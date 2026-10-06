using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste_de_5_por_100

{ /* Faça um algoritmo que leia um valor qualquer e imprima na tela com um 
reajuste de 5%.*/ 


    internal class Program
    {
        static void Main(string[] args)
        {

            int valor = 0, reajuste = 0;



            Console.WriteLine("Digite um valor qualquer: ");
            valor = int.Parse(Console.ReadLine());

            reajuste = (valor * 0.05) + valor;

            Console.WriteLine(" o reajuste de 5% do valor digitado é: " + reajuste);





        }
    }
}

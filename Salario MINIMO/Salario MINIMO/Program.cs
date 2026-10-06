using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_MINIMO
{   /* 2- Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse
           usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).*/

    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, vezes;

            Console.WriteLine(" Digite o valor de seu salario bruto:  ");
            salario = double.Parse(Console.ReadLine());

            vezes = salario / 1518;

            Console.WriteLine(" Seu salario é: " + vezes + " vezes o salario minimo");




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_desconto
{

    /* 
     
    5. Calcular desconto
    Um produto acima de  100 reais tem um desconto de 10%. Caso contrario, o desconto é de 5%.
    Dado o preço, calcule o valor do desconto.
    . Entra: 120
    . saida esperada: 12 reais de desconto
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            double precoProduto, descontoPreco;

            Console.Write("Digite o valor do produto:  ");
            precoProduto = double.Parse(Console.ReadLine());

            if (precoProduto > 100)

            {

                descontoPreco = precoProduto * 0.1;
                Console.WriteLine(descontoPreco +   " reais de desconto");

            }

            else
            {
                descontoPreco = precoProduto * 0.05;
                Console.WriteLine(descontoPreco +   " reais de desconto");
            }




        }
    }
}

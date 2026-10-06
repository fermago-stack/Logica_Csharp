using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Crescimento_Francisco_de_Sara
{ /* 10 - Francisco tem 1,50m e cresce 2 centímetros por ano, enquanto Sara tem 1,10m e 
cresce 3 centímetros por ano. Faça um algoritmo que calcule e imprima na tela em 
quantos anos serão necessários para que Sara seja maior que Francisco */

    internal class Program
    {
        static void Main(string[] args)
        {
            Double alturaFrancisco = 1.50;
            Double alturaSara = 1.10;
            Double crescimentoFrancisco = 0.02;
            Double crescimentoSara = 0.03;
            int anos = 0;

            while (alturaSara <= alturaFrancisco)
            {
                alturaFrancisco += crescimentoFrancisco;
                alturaSara += crescimentoSara;
                anos++;
            }

            Console.WriteLine("Serão necessários {0} anos para que Sara seja maior que Francisco.", anos);
        }
    }
}

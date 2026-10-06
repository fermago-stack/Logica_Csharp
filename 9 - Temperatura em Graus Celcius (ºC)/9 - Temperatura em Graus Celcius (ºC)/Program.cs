
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___temperatura_em_grau_Celsius

{ /* 9- Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a 
temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.
Fórmula: C = (5 * ( F-32) / 9*/

    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.Write("Digite a temperatura em Fahrenheit:  ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());


            celsius = 5 * ((fahrenheit - 32) / 9);

            Console.WriteLine("\nA temperatura em Celsius é:  " + celsius);
            Console.ReadKey();
        }
    }
}
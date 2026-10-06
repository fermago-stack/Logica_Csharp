
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Idade_exata
{ /* 8 - Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela 
quantos anos, meses e dias essa pessoa ja viveu. Leve em
consideração o ano com 365 dias e o mês com 30 dias.
(Ex: 5 anos, 2 meses e 15 dias de vida
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano em que você nasceu: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o mês em que você nasceu: ");
            int mesNascimento = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o dia em que você nasceu: ");
            int diaNascimento = int.Parse(Console.ReadLine());

            DateTime dataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);
            DateTime dataAtual = DateTime.Now;
            TimeSpan idade = dataAtual - dataNascimento;

            int anos = (int)(idade.Days / 365);
            int meses = (int)((idade.Days % 365) / 30);
            int dias = (int)((idade.Days % 365) % 30);

            Console.WriteLine("\n Você tem   " + anos + " anos, " + meses + " meses e   " + dias + " dias de vida.  ");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome; //variavel cadeia
            int idade; // variavel inteiro
            Console.WriteLine("digite seu nome:  "); // escreva
            nome= Console.ReadLine();// leia
            Console.WriteLine(" digite sua idade:  ");
            idade = int.Parse(Console.ReadLine()); // converte o que digitar em numero inteiro
            Console.WriteLine(" Parabens " + nome + " Voce acaba de ganhar uma coca-cola");
            Console.WriteLine("\n Voce possui " + idade + "  anos, beba mais agua");




                }
    }
}

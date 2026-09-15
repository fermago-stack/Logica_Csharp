using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_e_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            string nome;

            Console.Write(" Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write(" Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write(" Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write(" Digite a terceira nota: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write(" Digite a quarta nota: ");
            n4 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4);

            Console.Write(" O nome do aluno é: " + nome + " e a media dele é:  " +media);


        }
    }
}

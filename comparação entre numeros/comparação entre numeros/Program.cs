using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparação_entre_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;

            Console.Write(" Digite o primeiro numero:   ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write(" Digite o segundo numero:   ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write(" Digite o terceiro numero:   ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write(" Digite o quarto numero:   ");
            n4 = int.Parse(Console.ReadLine());
            Console.Write(" Digite o quinto numero:   ");
            n5 = int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 > n3 && n1 > n4 && n1 > n5) { Console.WriteLine("o maoir numero é:  " + n1); }

            if (n2 < n1 && n2 > n3 && n2 > n4 && n2 > n5) { Console.WriteLine("\n o maoir numero é:  " + n2); }

            if (n3 < n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine("\n o maoir numero é:  " + n3);
                if (n4 < n1 && n4 > n2 && n4 > n3 && n4 > n5) { Console.WriteLine("\n o maoir numero é:  " + n4); }
            }
            else
            {
                Console.WriteLine("\n o maoir numero é:  " + n5);







            }
        }
    }
}

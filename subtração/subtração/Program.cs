using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sub;

            Console.Write(" digite o primeiro numero  ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write(" digite o segundo numero  ");
            n2 = int.Parse(Console.ReadLine());

            sub = n1 - n2;

            Console.Write(" O resultado da subtração é:   " + sub);




        }
    }
}

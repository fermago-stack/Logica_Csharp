using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregador_Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;

            Console.Write("digite o tempo de entrega em minutos:   ");
            time = int.Parse(Console.ReadLine());

            if (time <= 0)
            {
                Console.Write(" Entrega perfeita! Bonus garantido:   ");

                if (time > 15 && time < 30)
                {
                    Console.Write(" Pizza entregue a tempo sem bonus:   ");
                }

                else
                {
                    Console.Write(" Pizza esfriou, entregador demitido!:   ");

                }
            }
        }
    }
    }
    

using System;

namespace Temperaturas_Diarias
{
    // Armazena as temperaturas diárias de uma cidade durante uma semana
    // e informa o dia mais quente e o mais frio.
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];

            string[] dias =
            {
                "Domingo",
                "Segunda-feira",
                "Terça-feira",
                "Quarta-feira",
                "Quinta-feira",
                "Sexta-feira",
                "Sábado"
            };

            double max = double.MinValue;
            double min = double.MaxValue;

            int diaMax = 0;
            int diaMin = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Digite a temperatura do dia {dias[i]}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());

                if (temperaturas[i] > max)
                {
                    max = temperaturas[i];
                    diaMax = i;
                }

                if (temperaturas[i] < min)
                {
                    min = temperaturas[i];
                    diaMin = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Dia mais quente: {dias[diaMax]} com {max}°C");
            Console.WriteLine($"Dia mais frio: {dias[diaMin]} com {min}°C");

            Console.ReadKey();
        }
    }
}
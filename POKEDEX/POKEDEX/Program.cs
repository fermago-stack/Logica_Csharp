using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEDEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomePokemon = { "Pikachu       ", "Bulbasaur      ", "Charmander      " , "Squirtle       " ,"Zubat     "," Meowth    ",   
                    "Psyduck       " , " Poliwag       " ," Machop       ",  " Poliwhirl      "};

            string[] tipoPokemon = { "Elétrico      ", "Grama/Veneno  ","   fogo      ", "Água          ", "Voador/Venenoso", "Normal        ", "" +
                    "Água          ", "Água          ", "Lutador       ", "Água          "};

            string[]   pesoPokemon = {
                "6.0 Kg",  // Pikachu
                "6.9 Kg",  // Bulbasaur
                "8.5 Kg",  // Charmander
                "9.0 Kg",  // Squirtle
                "7.5 Kg",  // Zubat
                "4.2 Kg",  // Meowth
                "19.6 Kg", // Psyduck
                "12.4 Kg", // Poliwag
                "19.5 Kg", // Machop
                "20.0 Kg"  // Poliwhirl
            };

            string[] tamanhoPokemon = {

                "0.4m",  // Pikachu
                "0.7m",  // Bulbasaur
                "0.6 m",  // Charmander
                "0.5 m",  // Squirtle
                "0.8 m",  // Zubat
                "0.4 m",  // Meowth
                "0.8 m",  // Psyduck
                "0.6 m",  // Poliwag
                "0.8 m",  // Machop
                "1.0 m"   // Poliwhirl


            };
                



            string[] alturaPokemon = {
                "0.4 m",  // Pikachu
                "0.7 m",  // Bulbasaur
                "0.6 m",  // Charmander
                "0.5 m",  // Squirtle
                "0.8 m",  // Zubat
                "0.4 m",  // Meowth
                "0.8 m",  // Psyduck
                "0.6 m",  // Poliwag
                "1.6 m",  // Machop
                "1.2 m"   // Poliwhirl

            };

            string [] numeroPokemon =
            {
                "25",  // Pikachu
                "1",   // Bulbasaur
                "4",   // Charmander
                "7",   // Squirtle
                "41",  // Zubat
                "52",  // Meowth
                "54",  // Psyduck
                "60",  // Poliwag
                "66",  // Machop
                "61",   // Poliwhirl
            };


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n LISTA DE POKÉMONS!");
            Console.ResetColor();

            for (int i = 0; i < numeroPokemon.Length; i++)
            {
                Console.WriteLine("ID:          " + numeroPokemon[i]);
                Console.WriteLine("NOME         " + nomePokemon[i]);
                Console.WriteLine("TIPO         " + tipoPokemon[i]);
                Console.WriteLine("ALTURA       " + tamanhoPokemon[i]);
                Console.WriteLine("PESO         " + pesoPokemon[i]);
                Console.WriteLine("===============================================================");

            }




        }
    }
}

                
            

        
    


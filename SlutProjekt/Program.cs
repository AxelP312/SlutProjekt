using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Här anropar jag Pokemon.cs genom att lägga in parametrar i funktionen Pokemon(). 
            //Namn, Hp, Dmg, Spd, def
            //För att se t.ex. Magikarps attack skriver man "Magikarp.Damage".
            //lista + List add på varje
            List<Pokemon> pokemonLista = new List<Pokemon>();
            pokemonLista.Add(new Pokemon("Bulbasaur", 45, 49, 45, 49));
            pokemonLista.Add(new Pokemon("Charmander", 39, 52, 42, 65));
            pokemonLista.Add(new Pokemon("squirtle", 44, 48, 65, 43));

            Console.WriteLine(pokemonLista[0].name);
            Console.ReadLine();


        }
    }
}

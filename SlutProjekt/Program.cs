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
            Pokemon Magikarp = new Pokemon("Magikarp", 50, 5, 80, 20);
            Pokemon Ditto = new Pokemon("Ditto", 48, 48, 48, 48);
            

        }
    }
}

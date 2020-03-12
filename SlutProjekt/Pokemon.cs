using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class Pokemon
    {
        public string name;
        public int health;
        public int damage;
        public int speed;
        public int defense;
        
        /*Funktion som tar in parametrar från Program.cs och definerar sedan vad för saker pokemonen har.
         För att anropa den här metoden gör man */
        public Pokemon(string n, int hp, int dmg, int spd, int def)
        {
            name = n;
            damage = dmg;
            health = hp;
            speed = spd;
            defense = def;
        }
    }
}

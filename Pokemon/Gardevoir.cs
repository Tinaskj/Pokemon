using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Gardevoir : IPokemon
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Gardevoir()
        {
        Name = "Gardevoir";
        Health = 220;
        }

        public void LooseHealth(int damage)
        {
            Health -= damage;
        }

        public void DrainingKiss(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used DrainingKiss");
            opponent.LooseHealth(90);
        }

        public void Psybeam(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Psybeam");
            opponent.LooseHealth(70);
        }

        public void DreamEater(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used DreamEater");
            opponent.LooseHealth(140);
        }
    }

}

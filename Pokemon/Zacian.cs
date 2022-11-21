using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Zacian : IPokemon
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public Zacian()
        {
            Name = "Zacian";
            Health = 500;
        }

        public void LooseHealth(int damage)
        {
            Health -= damage;
        }

        public void Moonblast(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Moonblast");
            opponent.LooseHealth(120);
        }

        public void CloseCombat(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used CloseCombat");
            opponent.LooseHealth(60);
        }

        public void GigaImpact(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used GigaImpact");
            opponent.LooseHealth(120);
        }
        
        public void IronHead(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used IronHead");
            opponent.LooseHealth(75);
        }

        
    }
}

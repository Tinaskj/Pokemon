using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Magikarp : IPokemon
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        private bool IsUseless { get; set; }

        public Magikarp()
        {
            Name = "Magikarp";
            Health = 320;
        }

        public void LooseHealth(int damage)
        {
            Health -= damage;
        }

        public void Splash(IPokemon opponent)
        {
            opponent.LooseHealth(0);
            Console.WriteLine($"{Name} used Splash");
        }
    }
}

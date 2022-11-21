using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pokemon
{
    internal class Gengar : IPokemon
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Gengar()
        {
            Name = "Gengar";
            Health = 280;
        }

        public void LooseHealth(int damage)
        {
            Health -= damage;
        }

        public void ShadowClaw(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used ShadowClaw");
            opponent.LooseHealth(85);
        }

        public void ShadowBall(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used ShadowBall");
            opponent.LooseHealth(65);
        }

        public void DarkPulse(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used DarkPulse");
            opponent.LooseHealth(105);
        }
    }
}

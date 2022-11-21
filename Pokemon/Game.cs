using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Game
    {
        public List<IPokemon> wildPokemon { get; set; }
        Random rnd = new Random();


        public Game()
        {
            
            wildPokemon = new List<IPokemon>
            {
                new Gengar(),
                new Gardevoir(),
                new Zacian(),
            };
           
        }

        public void Fight()
        {
            
            var magikarp = new Magikarp();

            int randomPokemonIndex = rnd.Next(wildPokemon.Count);
            var randomPokemon = wildPokemon[randomPokemonIndex];

            while (true)
            {
                
                if (randomPokemon.Name == "Gengar")
                {
                    var gengar = randomPokemon as Gengar;
                    Console.WriteLine("Your pokemon is Gengar. Choose which attack you want to use: ");
                    Console.WriteLine("1.Shadow Claw");
                    Console.WriteLine("2.Shadow Ball");
                    Console.WriteLine("3.Dark Pulse");
                    var chosenAttack = Convert.ToInt32(Console.ReadLine());
                    if (chosenAttack == 1) {gengar.ShadowClaw(magikarp);}
                    else if (chosenAttack == 2) {gengar.ShadowBall(magikarp);}
                    else if (chosenAttack == 3) {gengar.DarkPulse(magikarp);}
                    if (magikarp.Health <= 0) { Console.WriteLine("Magikarp fainted.You won!");  return;  }
                    magikarp.Splash(gengar);
                }
                else if (randomPokemon.Name == "Gardevoir")
                {
                    var gardevoir = randomPokemon as Gardevoir;
                    Console.WriteLine("Your pokemon is Gardevoir. Choose which attack you want to use: ");
                    Console.WriteLine("1.Draining Kiss");
                    Console.WriteLine("2.Psybeam");
                    Console.WriteLine("3.Dream Eater");
                    var chosenAttack = Convert.ToInt32(Console.ReadLine());
                    if (chosenAttack == 1) {gardevoir.DrainingKiss(magikarp);}
                    else if (chosenAttack == 2) {gardevoir.Psybeam(magikarp);}
                    else if (chosenAttack == 3) {gardevoir.DreamEater(magikarp);}
                    if (magikarp.Health <= 0) {Console.WriteLine("Magikarp fainted.You won!"); return; }
                    magikarp.Splash(gardevoir);
                }

                else if (randomPokemon.Name == "Zacian")
                {
                    var zacian = randomPokemon as Zacian;
                    Console.WriteLine("Your pokemon is Zacian. Choose which attack you want to use: ");
                    Console.WriteLine("1.Moonblast");
                    Console.WriteLine("2.Close Combat");
                    Console.WriteLine("3.Giga Impact");
                    Console.WriteLine("4.Iron Head");
                    var chosenAttack = Convert.ToInt32(Console.ReadLine());
                    if (chosenAttack == 1) {zacian.Moonblast(magikarp);}
                    else if (chosenAttack == 2) {zacian.CloseCombat(magikarp);}
                    else if (chosenAttack == 3) {zacian.GigaImpact(magikarp);}
                    else if (chosenAttack == 4) {zacian.IronHead(magikarp);}
                    if(magikarp.Health <= 0) { Console.WriteLine("Magikarp fainted.You won!"); return; }
                    magikarp.Splash(zacian);
                }

            }
        
        }
    }
        
    }

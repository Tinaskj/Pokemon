
namespace Pokemon
{
    internal interface IPokemon
    {
        public string Name { get; }
        public int Health { get; }
        public void LooseHealth(int damage);
        
    }
}

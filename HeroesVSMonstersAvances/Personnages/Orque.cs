using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    internal class Orque : Monstre, IOr
    {
        public Orque()
        {
            Or = De6.Lance();
        }

        public override int Force => base.Force + 1;

        public int Or { get; set; }
    }
}
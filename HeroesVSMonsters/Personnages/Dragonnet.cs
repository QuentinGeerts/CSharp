using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    internal class Dragonnet : Monstre, IOr, ICuir
    {
        public Dragonnet()
        {
            Cuir = De4.Lance();
            Or = De6.Lance();
        }

        public override int Endurance => base.Endurance + 1;

        public int Cuir { get; }

        public int Or { get; }
    }
}
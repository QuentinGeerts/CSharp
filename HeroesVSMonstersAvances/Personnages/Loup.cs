using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    internal class Loup : Monstre, ICuir
    {
        public Loup()
        {
            Cuir = De4.Lance();
        }

        public int Cuir { get; set; }
    }
}
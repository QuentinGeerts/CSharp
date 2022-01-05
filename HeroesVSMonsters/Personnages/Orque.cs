using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    class Orque : Monstre, IOr
    {
        private int _Or;

        public int Or
        {
            get { return _Or; }
            set { _Or = value; }
        }

        public override int Force { get => base.Force + 1; }

        public Orque()
        {
            Or = De6.Lance();
        }


    }
}

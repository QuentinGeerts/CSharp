using System;

using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    class Dragonnet : Monstre, IOr, ICuir
    {
        private int _Or;
        private int _Cuir;

        public int Or
        {
            get { return _Or; }
            private set { _Or = value; }
        }
        
        public int Cuir
        {
            get { return _Cuir; }
            private set { _Cuir = value; }
        }

        public override int Endurance { get => base.Endurance + 1; }

        public Dragonnet()
        {
            Cuir = De4.Lance();
            Or = De6.Lance();
        }
    }
}

using System;

using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    class Loup : Monstre, ICuir
    {
        private int _Cuir;

        public int Cuir
        {
            get { return _Cuir; }
            set { _Cuir = value; }
        }

        public Loup()
        {
            Cuir = De4.Lance();
        }
    }
}

using System;

using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    class Hero : Personnage
    {
        private int _Or, _Cuir;

        public int Or
        {
            get { return _Or; }
            set { _Or = value; }
        }

        public int Cuir
        {
            get { return _Cuir; }
            set { _Cuir = value; }
        }

        public void SeReposer()
        {
            ResetPV();
        }

        public void Depouiller(Monstre monstre)
        {
            if ( monstre is IOr )
            {
                Console.WriteLine($"[Dépouille] {((IOr)monstre).Or} or(s)");
                _Or += ( (IOr) monstre ).Or;
            }
            if ( monstre is ICuir )
            {
                Console.WriteLine($"[Dépouille] {((ICuir)monstre).Cuir} cuir(s)");
                _Cuir += ( (ICuir) monstre ).Cuir;
            }
        }
    }
}

using System;
using HeroesVSMonsters.Interfaces;

namespace HeroesVSMonsters.Personnages
{
    internal class Hero : Personnage
    {
        public int Or { get; set; }

        public int Cuir { get; set; }

        public void SeReposer()
        {
            ResetPV();
        }

        public void Depouiller(Monstre monstre)
        {
            if (monstre is IOr)
            {
                Console.WriteLine($"[Dépouille] {((IOr)monstre).Or} or(s)");
                Or += ((IOr)monstre).Or;
            }

            if (monstre is ICuir)
            {
                Console.WriteLine($"[Dépouille] {((ICuir)monstre).Cuir} cuir(s)");
                Cuir += ((ICuir)monstre).Cuir;
            }
        }
    }
}
using System;

namespace GestionBanque.Model
{
    // Surcharger l’opérateur « + » de la classe « Courant » afin qu’il retourne la somme, de type double, des soldes.
    // Cependant, les soldes négatifs ne doivent pas être pris en compte.

    class Courant : Compte
    {
        // Attributs        
        private double _LigneDeCredit;
        
        // Propriétés
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set
            {
                if (value < 0) return; // À remplacer plus tard par une exception

                _LigneDeCredit = value;
            }
        }

        // Méthodes
        public override void Retrait(double Montant)
        {
            Retrait(Montant, LigneDeCredit);
        }
    }
}

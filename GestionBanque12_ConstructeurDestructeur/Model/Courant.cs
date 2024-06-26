﻿namespace GestionBanque.Model
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

        // Constructeurs
        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Courant(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }

        // Méthodes
        public override void Retrait(double Montant)
        {
            Retrait(Montant, LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            //if (Solde < 0)
            //{
            //    return Solde * 9.75 / 100;
            //}
            //else
            //{
            //    return Solde * 3 / 100;
            //}
            return (Solde < 0 ? Solde * 9.75 : Solde * 3) / 100;
        }
    }
}

using System;

namespace GestionBanque.Model
{
    // Surcharger l’opérateur « + » de la classe « Courant » afin qu’il retourne la somme, de type double, des soldes.
    // Cependant, les soldes négatifs ne doivent pas être pris en compte.

    internal class Courant
    {
        private double _LigneDeCredit;

        // Attributs

        // Propriétés
        public string Numero { get; set; }

        public double Solde { get; private set; }

        public double LigneDeCredit
        {
            get => _LigneDeCredit;
            set
            {
                if (value < 0) return; // À remplacer plus tard par une exception

                _LigneDeCredit = value;
            }
        }

        public Personne Titulaire { get; set; }

        // Surcharge d'opérateurs
        public static double operator +(double Solde, Courant Courant)
        {
            return Solde + (Courant.Solde > 0.0 ? Courant.Solde : 0.0);
        }

        // Méthodes
        public void Retrait(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            if (Solde - Montant < -LigneDeCredit) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Retrait] : Compte n°{Numero} de {Montant}e");
            Solde -= Montant;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Dépot] : Compte n°{Numero} de {Montant}e");
            Solde += Montant;
        }
    }
}
using System;

namespace GestionBanque.Model
{
    internal class Epargne
    {
        // Attributs

        // Propriétés
        public string Numero { get; set; }

        public double Solde { get; private set; }

        public DateTime DateDernierRetrait { get; private set; }

        public Personne Titulaire { get; set; }

        // Méthodes
        public void Retrait(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            if (Solde - Montant < 0) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Retrait] : Compte n°{Numero} de {Montant}e");

            Solde -= Montant;
            DateDernierRetrait = DateTime.Now;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Dépot] : Compte n°{Numero} de {Montant}e");
            Solde += Montant;
        }
    }
}
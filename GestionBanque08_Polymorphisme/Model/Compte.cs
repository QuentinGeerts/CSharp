using System;

namespace GestionBanque.Model
{
    // Définir la classe « Compte » reprenant les parties commune aux classes « Courant » et
    // « Epargne » en utilisant les concepts d’héritage, de redéfinition de méthodes et si besoin,
    // de surcharge de méthodes et d’encapsulation.
    // Attention le niveau d’accessibilité du mutateur de la propriété Solde doit rester « private ».

    internal class Compte
    {
        // Propriétés
        public string Numero { get; set; }

        public double Solde { get; private set; }

        public Personne Titulaire { get; set; }

        // Méthodes
        public virtual void Retrait(double Montant)
        {
            Retrait(Montant, 0.0);
        }

        public void Retrait(double Montant, double LigneDeCredit)
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

        // Surcharge d'opérateurs
        public static double operator +(double Solde, Compte Compte)
        {
            return Solde + (Compte.Solde > 0.0 ? Compte.Solde : 0.0);
        }
    }
}
using System;

namespace GestionBanque.Model
{
    internal abstract class Compte : IBanker
    {
        // Constructeurs
        public Compte(string numero, Personne titulaire) : this(numero, titulaire, 0)
        {
        }

        public Compte(string numero, Personne titulaire, double solde)
        {
            Numero = numero;
            Titulaire = titulaire;
            Solde = solde;
            Console.WriteLine($"Compte {GetType().Name} créé.");
        }

        // Propriétés
        public string Numero { get; }

        public double Solde { get; private set; }

        public Personne Titulaire { get; }

        // Méthodes
        public virtual void Retrait(double Montant)
        {
            Retrait(Montant, 0.0);
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Dépot] : Compte n°{Numero} de {Montant}e");
            Solde += Montant;
        }

        public void AppliquerInteret()
        {
            Console.WriteLine($"[AppliquerInteret] Compte n°{Numero} Solde AVANT : {Solde}e");
            Solde += CalculInteret();
            Console.WriteLine($"[AppliquerInteret] Compte n°{Numero} Solde APRES : {Solde}e");
        }

        public void Retrait(double Montant, double LigneDeCredit)
        {
            if (Montant <= 0) return; // À remplacer plus tard par une exception

            if (Solde - Montant < -LigneDeCredit) return; // À remplacer plus tard par une exception

            Console.WriteLine($"[Retrait] : Compte n°{Numero} de {Montant}e");
            Solde -= Montant;
        }

        protected abstract double CalculInteret();

        // Surcharge d'opérateurs
        public static double operator +(double Solde, Compte Compte)
        {
            return Solde + (Compte.Solde > 0.0 ? Compte.Solde : 0.0);
        }
    }
}
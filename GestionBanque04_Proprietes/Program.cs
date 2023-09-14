using System;
using GestionBanque.Model;

namespace GestionBanque04_Proprietes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Création des personnes

            Console.WriteLine("-- Création des personnes --");
            var Adrian = new Personne();
            Adrian.Nom = "Prevot";
            Adrian.Prenom = "Adrian";
            Adrian.DateNaiss = DateTime.Now;

            var Mathieu = new Personne
            {
                Nom = "Meurée",
                Prenom = "Mathieu",
                DateNaiss = DateTime.Now
            };

            #endregion

            #region Création des comptes courants

            Console.WriteLine("-- Création des comptes courants --");
            var AdrianCourant = new Courant();
            AdrianCourant.Titulaire = Adrian;
            AdrianCourant.Numero = "001";
            //AdrianCourant.Solde = 1500; // Ne fonctionne pas => private set
            AdrianCourant.LigneDeCredit = 100;

            Console.WriteLine(AdrianCourant.Solde);
            AdrianCourant.Depot(500);
            Console.WriteLine(AdrianCourant.Solde);
            AdrianCourant.Retrait(610);
            Console.WriteLine(AdrianCourant.Solde);
            AdrianCourant.Retrait(100);
            Console.WriteLine(AdrianCourant.Solde);

            #endregion
        }
    }
}
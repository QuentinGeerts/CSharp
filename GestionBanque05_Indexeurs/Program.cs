using GestionBanque.Model;
using System;

namespace GestionBanque05_Indexeurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Title("-- Gestion de banque - C# OO --");

            #region Création des personnes
            Title("Création des personnes");
            Personne Adrian = new Personne();
            Adrian.Nom = "Prevot";
            Adrian.Prenom = "Adrian";
            Adrian.DateNaiss = DateTime.Now;

            Personne Mathieu = new Personne()
            {
                Nom = "Meurée",
                Prenom = "Mathieu",
                DateNaiss = DateTime.Now
            };
            #endregion

            #region Création des comptes courants
            Title("Création des comptes courants");
            Courant AC = new Courant();
            AC.Titulaire = Adrian;
            AC.Numero = "001";
            //AdrianCourant.Solde = 1500; // Ne fonctionne pas => private set
            AC.LigneDeCredit = 100;

            AC.Depot(500);
            AC.Retrait(610);
            AC.Retrait(100);

            Courant MC = new Courant();
            MC.Titulaire = Mathieu;
            MC.Numero = "002";
            MC.LigneDeCredit = 500;

            MC.Depot(1000);
            MC.Retrait(50);
            #endregion

            #region Création de la banque
            Title("Création de la banque");
            Banque b = new Banque();
            b.Nom = "Ma Banque";

            b.Ajouter(AC);
            b.Ajouter(MC);

            b["001"].Depot(30);
            b["002"].Retrait(300);
            #endregion
        }

        static void Title(string str)
        {
            Console.WriteLine();
            Console.WriteLine($"---- {str} ----");
        }
    }
}

using System;

namespace _12_ConstructeursDestructeurs;

internal class Program
{
    private static void Main(string[] args)
    {
        //Personne personne = new Personne("Geerts", "Quentin", DateTime.Now, 180, 90);
        ////{
        ////    Nom = "Geerts"
        ////};
        ////personne.Nom = "Geerts";

        //Console.WriteLine(personne);

        //Personne personne1 = new Personne("Storella", "Dorian");

        //Console.WriteLine(personne1);

        //Personne personne2 = new Personne();
        //Console.WriteLine(personne2);

        //Eleve eleve = new Eleve() { Prenom = "Quentin" };
        //eleve.Nom = "Geerts";

        var eleve = new Eleve("L001", "Geerts", "Quentin", DateTime.Now, 180, 90);
        Console.WriteLine(eleve);

        var eleve1 = new Eleve("L002", "Prevot", "Adrian");
        Console.WriteLine(eleve1);
    }
}
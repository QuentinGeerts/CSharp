using System;

namespace Carwash2
{
    // Définir dans un nouveau projet un nouveau type de délégué ne revoyant rien et recevant en paramètre une « Voiture ».
    // La classe voiture contient :
    //   > une propriété « Plaque » de type string et en lecture seule
    //   > un constructeur recevant le numéro de plaque en paramètre.
    // Exercices :
    // 1. Créer une classe Carwash contenant 5 méthodes
    //   > private void Préparer(Voiture v) qui affiche « je prépare la voiture : {plaque} »
    //   > private void Laver(Voiture v) qui affiche « je lave la voiture : { plaque} »
    //   > private void Secher(Voiture v) qui affiche « je sèche la voiture : { plaque} »
    //   > private void Finaliser(Voiture v) qui affiche « je finalise la voiture : { plaque} »
    //   > public void Traiter(Voiture v) qui exécute les 4 méthodes précédentes dans l’ordre à l’aide d’un délégué.

    // 2. Remplacer les méthodes par des méthodes anonymes

    /*
     * Raccourcis :
     * ALT + Enter => Menu contextuel
     * CTRL + SHIFT + T => Atteindre fichier
     * CTRL + SHIFT + L => Supprimer la ligne
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Exercice Carwash - Utilisation des délégués");

            #region Création du Carwash et des voitures

            Title("Création du Carwash et des voitures");
            var carwash = new Carwash();

            var v1 = new Voiture("1-ABC-123");
            var v2 = new Voiture("1-ABC-124");
            var v3 = new Voiture("1-ABC-125");
            var v4 = new Voiture("1-ABC-126");

            #endregion

            #region Traitement des voitures

            Title("Traitement des voitures");

            carwash.Traiter(v1);
            carwash.Traiter(v2);
            carwash.Traiter(v3);
            carwash.Traiter(v4);

            #endregion
        }

        private static void Title(string str)
        {
            Console.WriteLine();
            Console.WriteLine($"~~~ {str} ~~~");
        }
    }
}
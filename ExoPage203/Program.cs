using System;

namespace ExoPage203
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Paquet de cartes
            var cartes = new Carte[52];

            // Initialisation du compteur de cartes
            var i = 0;

            // Parcourt des couleurs
            foreach (var couleur in Enum.GetNames(typeof(Couleur)))
            {
                Console.WriteLine($"\n▬ Création des {couleur} ▬\n");

                // Parcourt des valeurs
                foreach (var valeur in Enum.GetNames(typeof(Valeur)))
                {
                    cartes[i] = new Carte
                    {
                        Couleur = (Couleur)Enum.Parse(typeof(Couleur), couleur),
                        Valeur = (Valeur)Enum.Parse(typeof(Valeur), valeur)
                    };

                    Console.WriteLine($"{cartes[i].Couleur} {cartes[i].Valeur}");

                    i++;
                }
            }
        }
    }
}
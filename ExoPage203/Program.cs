using System;

namespace ExoPage203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paquet de cartes
            Carte[] cartes = new Carte[52];

            // Initialisation du compteur de cartes
            int i = 0;

            // Parcourt des couleurs
            foreach (string couleur in Enum.GetNames(typeof(Couleur)))
            {

                Console.WriteLine($"\n▬ Création des {couleur} ▬\n");

                // Parcourt des valeurs
                foreach (string valeur in Enum.GetNames(typeof(Valeur)))
                {
                    cartes[i] = new Carte()
                    {
                        Couleur = (Couleur)Enum.Parse(typeof(Couleur), couleur),
                        Valeur = (Valeur)Enum.Parse(typeof(Valeur),valeur)
                    };

                    Console.WriteLine($"{cartes[i].Couleur} {cartes[i].Valeur}");

                    i++;

                }

            }

        }
    }
}

using System;

namespace _05_Indexeurs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var deck = new Deck();
            deck.InitDeck();

            var main = new Card[7];

            for (var i = 0; i < main.Length; i++) main[i] = deck[0];

            foreach (var card in main) Console.WriteLine($"Le {card.Valeur} de {card.Couleur}");

            //Console.WriteLine(deck[-1]);

            main[3] = deck[Couleurs.Pique, Valeurs.Neuf];

            Console.WriteLine($"Le {main[3].Valeur} de {main[3].Couleur}");
        }
    }
}
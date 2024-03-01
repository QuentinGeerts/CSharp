using System;
using _05_Indexeurs.Models;

Deck deck = new Deck();
deck.InitDeck();

Card[] main = new Card[7];

for (int i = 0; i < main.Length; i++)
{
    main[i] = deck[0];
}

foreach (Card card in main)
{
    Console.WriteLine($"Le {card.Valeur} de {card.Couleur}");
}

//Console.WriteLine(deck[-1]);

main[3] = deck[Couleurs.Pique, Valeurs.Neuf];

Console.WriteLine($"Le {main[3].Valeur} de {main[3].Couleur}");
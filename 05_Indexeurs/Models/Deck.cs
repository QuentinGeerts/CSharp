using System;
using System.Collections.Generic;

namespace _05_Indexeurs.Models
{
    class Deck
    {
        // new() : Inference de type (<!> à partir de C# 9)
        private readonly List<Card> _deck = new(); 

        // Indexeur : Permet d'utiliser une classe possédant une liste
        // comme un tableau avec choix du type de clé
        // Dans ce cas-ci, un int index
        public Card this[int index]
        {
            get
            {
                Card c = null;
                if (index < _deck.Count && index >= 0)
                {
                    c = _deck[index];
                    _deck.Remove(c);
                }

                return c;
            }

            set
            {
                if (index < _deck.Count && index >= 0)
                {
                    _deck[index] = value;
                }
                else
                {
                    _deck.Add(value);
                }
            }
        }

        // Dans ce cas-ci, en fournissant une couleur et une valeur
        public Card this[Couleurs couleur, Valeurs valeur]
        {
            get
            {
                Card c = null;
                for (int i = 0; i < _deck.Count; i++)
                {
                    if (_deck[i].Couleur == couleur && _deck[i].Valeur == valeur)
                    {
                        c = _deck[i];
                        _deck.Remove(c);
                    }
                }
                return c;
            }
            set
            {
                Card c = null;

                foreach (Card card in _deck)
                {
                    if (card.Couleur == couleur && card.Valeur == valeur) c = card;

                    if (c is null)
                    {
                        _deck.Add(new Card() { Couleur = couleur, Valeur = valeur });
                    }
                }
            }
        }

        internal void InitDeck()
        {
            foreach (string colorName in Enum.GetNames(typeof(Couleurs)))
            {
                foreach (string valueName in Enum.GetNames(typeof(Valeurs)))
                {
                    Card card = new Card
                    {
                        Couleur = Enum.Parse<Couleurs>(colorName),
                        Valeur = Enum.Parse<Valeurs>(valueName)
                    };
                    _deck.Add(card);
                }
            }
        }
    }
}
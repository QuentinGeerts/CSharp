using System;
using System.Collections.Generic;

namespace _05_Indexeurs
{
    internal class Deck
    {
        private readonly List<Card> _Deck = new();

        public Card this[int index]
        {
            get
            {
                Card c = null;
                if (index < _Deck.Count && index >= 0)
                {
                    c = _Deck[index];
                    _Deck.Remove(c);
                }

                return c;
            }

            set
            {
                if (index < _Deck.Count && index >= 0)
                    _Deck[index] = value;
                else
                    _Deck.Add(value);
            }
        }

        public Card this[Couleurs couleur, Valeurs valeur]
        {
            get
            {
                Card c = null;
                for (var i = 0; i < _Deck.Count; i++)
                    if (_Deck[i].Couleur == couleur && _Deck[i].Valeur == valeur)
                    {
                        c = _Deck[i];
                        _Deck.Remove(c);
                    }

                return c;
            }
            set
            {
                Card c = null;

                foreach (var card in _Deck)
                {
                    if (card.Couleur == couleur && card.Valeur == valeur) c = card;

                    if (c is null) _Deck.Add(new Card { Couleur = couleur, Valeur = valeur });
                }
            }
        }

        internal void InitDeck()
        {
            foreach (var colorName in Enum.GetNames(typeof(Couleurs)))
            foreach (var valueName in Enum.GetNames(typeof(Valeurs)))
            {
                var card = new Card();
                card.Couleur = Enum.Parse<Couleurs>(colorName);
                card.Valeur = Enum.Parse<Valeurs>(valueName);
                _Deck.Add(card);
            }
        }
    }
}
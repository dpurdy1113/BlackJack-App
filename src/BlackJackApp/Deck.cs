using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackApp
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new Card((Rank)rank , (Suit)suit));
                }
            }

            Shuffle();
        }

        public void Shuffle()
        {
            Random rand = new Random();

            for (var i = 0; i < 500; i++)
            {
                var firstIdx = rand.Next(Cards.Count);
                var secondIdx = rand.Next(Cards.Count);

                var temp = Cards[firstIdx];
                Cards[firstIdx] = Cards[secondIdx];
                Cards[secondIdx] = temp;
            }
        }

        public Card DealCard()
        {
            if (Cards.Count() == 0)
            {
                return null;
            }
            var card = Cards[0];
            Cards.Remove(card);
            return card;
        }

        public List<Card> DealCards(int num)
        {
            List<Card> cards = new List<Card>();
            for (var i = 0; i < num; i++)
            {
                cards.Add(DealCard());
            }

            return cards;
        }
    }
}

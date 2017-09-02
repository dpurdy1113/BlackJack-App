using System.Collections.Generic;

namespace BlackJackApp
{
    public class Hand
    {
        public List<Card> Cards { get; set; }

        public Hand(List<Card> cards)
        {
            Cards = cards;
        }

        public void Hit(Card c)
        {
            Cards.Add(c);
        }

        public void AddCards(List<Card> cards)
        {
            foreach (Card c in cards)
            {
                Hit(c);
            }
        }

        public int Value
        {
            get
            {
                var sum = 0;
                var aceCount = 0;

                foreach (Card c in Cards)
                {
                    if (c.Rank == Rank.Ace)
                    {
                        aceCount++;
                    }

                    var RankValue = (int)c.Rank;

                    if (RankValue < 10)
                    {
                        sum += RankValue;
                    }
                    else
                    {
                        sum += 10;
                    }
                }

                if (sum + 10 <= 21 && aceCount > 0)
                {
                    sum += 10;
                }

                return sum;
            }
        }

        public override string ToString()
        {
            var output = "";

            foreach (Card c in Cards)
            {
                output += c.ToString() + " ";
            }

            return output.Trim();
        }
    }
}

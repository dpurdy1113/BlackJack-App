namespace BlackJackApp
{
    public enum Suit
    {
         Hearts,
        Spades,
        Diamonds,
        Clubs 
}
    public enum Rank
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    public class Card
    {
        public Rank Rank{ get; set; }
        public Suit Suit { get; set; }

        public Card(Rank r, Suit s)
        {
            Rank = r;
            Suit = s;
        }

        public override string ToString()
        {
            var output = "";

            switch (Rank)
            {
                case Rank.Ace:
                    output += "A";
                    break;
                case Rank.Two:
                    output += "2";
                    break;
                case Rank.Three:
                    output += "3";
                    break;
                case Rank.Four:
                    output += "4";
                    break;
                case Rank.Five:
                    output += "5";
                    break;
                case Rank.Six:
                    output += "6";
                    break;
                case Rank.Seven:
                    output += "7";
                    break;
                case Rank.Eight:
                    output += "8";
                    break;
                case Rank.Nine:
                    output += "9";
                    break;
                case Rank.Ten:
                    output += "10";
                    break;
                case Rank.Jack:
                    output += "J";
                    break;
                case Rank.Queen:
                    output += "Q";
                    break;
                case Rank.King:
                    output += "K";
                    break;
            }

            switch (Suit)
            {
                case Suit.Hearts:
                    output += "♥";
                    break;
                case Suit.Spades:
                    output += "♠";
                    break;
                case Suit.Diamonds:
                    output += "♦";
                    break;
                case Suit.Clubs:
                    output += "♣";
                    break;
            }


            return output;
        }
    }
    }


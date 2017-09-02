using System;

namespace BlackJackApp
{
    public class Program
    {

        public static void Main(string[] args)
        {

            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Deck deck = new Deck();

                Hand playerHand = new Hand(deck.DealCards(2));
                Hand dealerHand = new Hand(deck.DealCards(2));

                bool stay = false;
                bool bust = false;

                do
                {
                    Console.WriteLine("Your hand is " + playerHand.ToString() + " with a value of " + playerHand.Value);
                    Console.WriteLine("Do you want to >hit< or >stay<?");
                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "hit":
                            playerHand.Cards.Add(deck.DealCard());
                            break;
                        case "stay":
                            stay = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please enter \"hit\" or \"stay\".");
                            break;
                    }
                    if (playerHand.Value > 21)
                    {
                        bust = true;
                    };

                } while (!stay && !bust);

                Console.WriteLine("Your hand is " + playerHand.ToString() + " with a value of " + playerHand.Value);


                if (playerHand.Value > 21)
                {
                    Console.WriteLine("You busted!");
                }
                else
                {
                    Console.WriteLine("You got " + playerHand.Value);
                }

                Console.WriteLine("Dealer's hand is " + dealerHand.ToString() + " with a value of " + dealerHand.Value);
                while (dealerHand.Value <= 21)
                {
                    if (playerHand.Value > 21)
                    {
                        break;
                    }
                    if (dealerHand.Value < playerHand.Value && dealerHand.Value < 21)
                    {
                        dealerHand.Hit(deck.DealCard())
                        Console.WriteLine("Dealer's hand is " + dealerHand.ToString() + " with a value of " + dealerHand.Value);
                    }
                    if (dealerHand.Value > playerHand.Value && dealerHand.Value <= 21)
                    {
                        Console.WriteLine("Dealer's hand is " + dealerHand.ToString() + " with a value of " + dealerHand.Value + " Dealer wins!");
                        break;
                    };
                    if (dealerHand.Value == playerHand.Value && dealerHand.Value >= 17)
                    {
                        Console.WriteLine("Dealer's hand is " + dealerHand.ToString() + " with a value of " + dealerHand.Value + " It's a tie!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Dealer's hand is " + dealerHand.ToString() + " with a value of " + dealerHand.Value + " Player wins!");
                        break;
                    }
                }

                Console.WriteLine("Do you want to play again? type yes or no");
                string decision = Console.ReadLine();
                if (decision == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The next hand begins! Press enter to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}

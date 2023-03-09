using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a deck of cards
            List<string> cards = CreateDeck();

            // shuffle the deck
            Shuffle(cards);

            // deal two cards to each player
            List<string> player1Hand = new List<string>();
       

            // put the players' hands into a list for easier processing
            List<List<string>> playerHands = new List<List<string>> { player1Hand,};

            // deal two cards to each player
            foreach (List<string> hand in playerHands)
            {
                hand.Add(cards[0]);
                cards.RemoveAt(0);
                hand.Add(cards[0]);
                cards.RemoveAt(0);
                hand.Add(cards[0]);
                cards.RemoveAt(0);
                hand.Add(cards[0]);
                cards.RemoveAt(0);
                hand.Add(cards[0]);
                cards.RemoveAt(0);
                
            }

            // print the hands
            Console.WriteLine("Player 1's hand: ");
            PrintHand(player1Hand);

            // wait for user input before closing the console window
            Console.ReadLine();
        }

        private static List<string> CreateDeck()
        {
            List<string> cards = new List<string>();

            // create the suits and ranks
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            // create the cards
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(rank + " of " + suit);
                }
            }

            return cards;
        }

        private static void Shuffle(List<string> deck)
        {
            Random rng = new Random();

            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;
            }
        }

        private static void PrintHand(List<string> hand)
        {
            foreach (string card in hand)
            {
                Console.WriteLine(card);
            }
        }
    }
}

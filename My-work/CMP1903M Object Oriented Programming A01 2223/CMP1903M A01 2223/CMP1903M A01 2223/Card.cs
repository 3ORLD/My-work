using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum Value
    {
        Two = 2, Three, Four, Five, Six,
        Seven, Eight, Nine, Ten, King,
        Queen, Ace, Jack
    }

    public enum Suit
    {
        Hearts,
        Spades,
        Clubs,
        Diamonds
    }

    public class Card
    {
        public Suit Suit { get; }
        public Value Value { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return Value + " of " + Suit;
        }
    }
}

    
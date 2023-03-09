using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CMP1903M_A01_2223
{
    public class Pack
{
    private List<Card> pack;
    private int cardsDealt;

    public Pack()
    {
        // Initialise the card pack here
        pack = new List<Card>();
        for (int suit = 0; suit < 4; suit++)
        {
            for (int value = 2; value <= 14; value++)
            {
                pack.Add(new Card((Suit)suit, (Value)value));
            }
        }
        cardsDealt = 0;
    }

    public void ShuffleCardPack(int typeOfShuffle)
    {
        // Shuffles the pack based on the type of shuffle
        Random rnd = new Random();
        switch (typeOfShuffle)
        {
            case 1:
                // no shuffle
                break;
            case 2:
                // Fisher-Yates shuffle
                for (int i = pack.Count - 1; i > 0; i--)
                {
                    int j = rnd.Next(i + 1);
                    Card temp = pack[i];
                    pack[i] = pack[j];
                    pack[j] = temp;
                }
                break;
            case 3:
                // Riffle shuffle
                int mid = pack.Count / 2;
                List<Card> left = pack.Take(mid).ToList();
                List<Card> right = pack.Skip(mid).ToList();
                pack.Clear();
                while (left.Count > 0 || right.Count > 0)
                {
                    if (left.Count > 0)
                    {
                        pack.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    if (right.Count > 0)
                    {
                        pack.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                break;
            default:
                throw new ArgumentException("Invalid type of shuffle");
        }
        cardsDealt = 0;
    }

    public Card DealCard()
    {
        // Deals one card from the pack
        if (cardsDealt >= pack.Count)
        {
            throw new InvalidOperationException("All cards have been dealt");
        }
        Card card = pack[cardsDealt];
        cardsDealt++;
        return card;
    }

    public void ResetPack(int typeOfShuffle = 2)
    {
        // Resets the pack by setting cardsDealt to 0 and shuffling the pack
        cardsDealt = 0;
        ShuffleCardPack(typeOfShuffle);
    }
}
}
   
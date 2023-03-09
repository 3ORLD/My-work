using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public static void Main(string[] args)
        {
            Pack pack = new Pack();

            Console.WriteLine("Initial pack:");
            Console.WriteLine(string.Join(", ", pack));

            Console.WriteLine("\nFisher-Yates shuffle:");
            pack.ShuffleCardPack(2);
            Console.WriteLine(string.Join(", ", pack));

            Console.WriteLine("\nRiffle shuffle:");
            pack.ShuffleCardPack(3);
            Console.WriteLine(string.Join(", ", pack));

            Console.WriteLine("\nNo shuffle:");
            pack.ShuffleCardPack(1);
            Console.WriteLine(string.Join(", ", pack));


            Console.WriteLine("\nDealing one card after each shuffle:");
            for (int i = 0; i < 3; i++)
            {
                Card card = pack.DealCard();
                Console.WriteLine(card);
            }
        }
    }
}

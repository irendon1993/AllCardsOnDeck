using System;
using System.Collections.Generic;

namespace AllCardsOnDeck
{
    class Program

    {
        static void Main(string[] args)
        {
            var deck = new List<string>() { "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of of Clubs", "Eight of Clubs", "Nine of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of of Hearts", "Eight of Hearts", "Nine of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds" };
            var n = deck.Count;

            var randomNumberGenerator = new Random();

            for (var rightIndex = n - 1; rightIndex >= 0; rightIndex--)
            {

                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = deck[rightIndex];
                var rightCard = deck[leftIndex];
                deck[rightIndex] = rightCard;
                deck[leftIndex] = leftCard;
            }

            Console.WriteLine(deck[0]);
            Console.WriteLine(deck[1]);
        }
    }
}

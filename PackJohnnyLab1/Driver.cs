using System;

namespace Lab1
{
    class Driver
    {
        public static void Main()
        {
            Console.Title = "Lab 1 - Johnny Pack";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Deck deck = new Deck();
            int playerNumber = 0;
            for (int i = 0; i < 30; i++)
            {
                deck.Shuffle();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many cards are in one hand?");
            Console.ForegroundColor = ConsoleColor.Blue;
            int handSize = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How many players are playing?");
            Console.ForegroundColor = ConsoleColor.Blue;
            int players = Convert.ToInt32(Console.ReadLine());
            int cardsPlayed = players * handSize;
            if (cardsPlayed > 52)
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Not enough cards in the deck for the amount of players!");
                    Console.WriteLine("Press any key to exit the program!");
                    Console.ReadKey();
                    Environment.Exit(0);
            }

            for (int i = 1; i <= players; i++)
            {
                String hand = deck.DealAHand(handSize);
                playerNumber = i;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Player {i}'s Hand");
                Console.WriteLine("_____________________");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(hand);
                Console.ForegroundColor = ConsoleColor.Red;
                deck.Shuffle();
                Console.ReadKey();
            }
        }
    }
}

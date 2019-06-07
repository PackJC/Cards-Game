//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Lab 1 - Java to C#                                                                                  
//  File Name:      CardsDriver.cs
//  Description:    Runs the program
//  Course:         CSCI 2910-090                                                                             
//  Author:         Johnny Pack, packjc@etsu.edu, Department of Computing, East Tennessee State University
//                  
//  Created:        Thursday, June 6, 2019                                                                      
//  Copyright:      Johnny Pack, 2019                                                                           
//                                                                                                              
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace Lab1
{
    /// <summary>
    /// Driver class
    /// </summary>
    class CardsDriver
    {
        /// <summary>
        /// Main Menu method
        /// </summary>
        public static void Main()
        {
            StartUp();
            Deck deck = new Deck();

            Boolean loop = true;
            int handSize;
            int players;
            deck.Shuffle();
            while (loop == true)
            {
                Red();
                deck.NextCard = 0;
                Console.Write("How many cards are in one hand?");
                Blue();
                handSize = Convert.ToInt32(Console.ReadLine());
                Red();
                Console.Write("How many players are playing?");
                Blue();
                players = Convert.ToInt32(Console.ReadLine());

                int check = players * handSize;
                while (check > 52)
                {
                    Console.Clear();
                    Red();
                    Console.WriteLine("Number of cards over 52.");
                    Console.Write("How many cards are in one hand?");
                    Blue();
                    handSize = Convert.ToInt32(Console.ReadLine());
                    Red();
                    Console.Write("How many players are playing?");
                    Blue();
                    players = Convert.ToInt32(Console.ReadLine());
                    check = players * handSize;
                    Blue();
                }
                Console.WriteLine("\n\n");
                for (int i = 1; i <= players; i++)
                {
                    Red();
                    Console.WriteLine($"Player {i}'s Hand:");
                    Blue();
                    Console.WriteLine(deck.DealAHand(handSize));
                    Red();
                    deck.Shuffle();
                }
                Red();
                Console.WriteLine("Press 1 to continue! Any other number to exit!");
                Blue();
                int validateInteger;
                String validateString = Console.ReadLine();

                while (!Int32.TryParse(validateString, out validateInteger))
                {
                    Red();
                    Console.WriteLine("Not a valid number, try again.");
                    Blue();
                    validateString = Console.ReadLine();
                }
                if (validateString == "1")
                {
                    loop = true;
                    Console.Clear();
                }
                else
                {
                    loop = false;
                    Environment.Exit(0);
                }

            }
        }
        /// <summary>
        /// Quickly changes console text color to Blue
        /// </summary>
        public static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        /// <summary>
        /// Quickly changes console text color to Red
        /// </summary>
        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        /// <summary>
        /// Startup Console Formatting to make program look pretty
        /// </summary>
        public static void StartUp()
        {
            Console.Title = "Lab 1 - Johnny Pack";
            Blue();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
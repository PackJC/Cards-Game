//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Lab 1 - Java to C#                                                                                  
//  File Name:      Driver.cs
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
    class Driver
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main()
        {
            StartUp();
            Deck deck = new Deck();
            Boolean loop = true;
            Boolean EndLoop = true;
            int choice = 0;
            int handSize;
            int players;
            int cardsPlayed;
            deck.Shuffle();
            do
            {
                Console.Clear();
                loop = true;
                EndLoop = true;
                choice = 0;
                try
                {
                Red();
                Console.Write("How many cards are in one hand?");
                Blue();
                 handSize = Convert.ToInt32(Console.ReadLine());
                Red();
                Console.Write("How many players are playing?");
                Blue();
                 players = Convert.ToInt32(Console.ReadLine());
                 cardsPlayed = players * handSize;
 
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
                if(cardsPlayed  > 52)
                {
                    Red();
                    Console.Clear();
                    Console.WriteLine("Not enough cards in the deck for the amount of players! \nPress any key to try again!");
                    Console.ReadKey();
                }

                }
                catch
                {
                    Red();
                    Console.WriteLine("\n\n\t\t\t\tERROR: Invalid input! Please start over!\n\n");
                    loop = true;
                }
                
               
                Red();
                Console.Write("\t\t\t\tPress 1 to continue using program.\n\t\t\t\tPress 2 to exit the program.\n");
                while(EndLoop == true)
                {
                    try
                    {
                        Red();
                        Console.Write("Choice: ");
                        Blue();
                        choice = Convert.ToInt32(Console.ReadLine());
                        if(choice < 1 && choice > 2)
                        {                          
                            Console.Clear();
                            Red();
                            Console.WriteLine("ERROR: Invalid input! Please enter 1 to continue or 2 to exit!\n");
                            EndLoop = true;
                        }
                        else
                        {
                            EndLoop = false;
                        }
                        
                    }
                    catch
                    {
                        Console.Clear();
                        Red();
                        Console.WriteLine("ERROR: Invalid input! Please enter 1 to continue or 2 to exit!\n");
                    }
                }
                if(choice == 2)
                {
                    loop = false;
                }
                
            } while (loop);
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Lab 1 - Java to C#                                                                                  
//  File Name:      Deck.cs
//  Description:    Deck Class
//  Course:         CSCI 2910-090                                                                             
//  Author:         Johnny Pack, packjc@etsu.edu, Department of Computing, East Tennessee State University
//                  
//  Created:        Thursday, June 6, 2019                                                                      
//  Copyright:      Johnny Pack, 2019                                                                           
//                                                                                                              
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Text;

namespace Lab1
{
    /// <summary>
    /// Deck Class
    /// </summary>
    class Deck
    {
        /// <summary>
        /// Card array, a deck of cards
        /// </summary>
        private readonly Card[] deck = new Card[52];
        /// <summary>
        /// Next card
        /// </summary>
        public int NextCard { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Deck()
        {
            NextCard = 0;

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(i);
            }

        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="existingDeck">Incoming copy of a deck</param>
        public Deck(Deck existingDeck)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(existingDeck.deck[i]);
            }
        }
        /// <summary>
        /// Shuffles card array around
        /// </summary>
        public void Shuffle()
        {
            Random ran = new Random();

            for (int i = 0; i < 52; i++)
            {
                int ranNum = ran.Next(52);
                Card mixedCard = deck[ranNum];
                deck[ranNum] = deck[i];
                deck[i] = mixedCard;
            }
        }
        /// <summary>
        /// Returns a card
        /// </summary>
        /// <returns>Card out of a deck</returns>
        public Card DealACard()
        {

            Card deltCard = new Card(deck[NextCard]);

            NextCard++;

            return deltCard;
        }
        /// <summary>
        /// Returns a hand
        /// </summary>
        /// <param name="HandSize"></param>
        /// <returns>A hand of cards</returns>
        public Hand DealAHand(int HandSize = 5)
        {
            Hand hand = new Hand(HandSize);
            for (int i = 0; i < HandSize; i++)
            {
                hand.AddCard(DealACard());
            }
            return hand;
        }
        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Deck</returns>
        public override String ToString()
        {
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < 52; i++)
            {
                str.AppendLine(deck[i].ToString());
            }
            return str.ToString();
        }
    }
}

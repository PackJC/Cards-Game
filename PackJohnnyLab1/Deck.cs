//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Lab 1 - Java to C#                                                                                  
//  File Name:      Deck.cs
//  Description:    Deck class to construct a Deck of cards
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
        /// public random to access over methods
        /// </summary>
        public Random ran = new Random();
        /// <summary>
        /// Integer of the next card
        /// </summary>
        private int nextCard;
        /// <summary>
        /// List of cards named deck
        /// </summary>
        private Card[] deck = new Card[52];
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                deck[i] = new Card(i);
            }
        }
        /// <summary>
        /// Deep copy constructor
        /// </summary>
        /// <param name="deckIn"></param>
        public Deck(Deck deckIn)
        {
            for (int i = 0; i < 52; i++)
            {
                this.deck[i] = deckIn.deck[i];
            }
        }
        /// <summary>
        /// Shuffle's cards in random position
        /// </summary>
        public void Shuffle()
        {
            int ranNum = ran.Next(52);
            for (int i = 0; i < 52; i++)
            {
                Card mixedCard = deck[ranNum];
                deck[ranNum] = deck[i];
                deck[i] = mixedCard;
            }
            nextCard = 0;
        }
        /// <summary>
        /// Cards left in the collection
        /// </summary>
        /// <returns></returns>
        public int CardsLeft()
        {
            int cardsLeft = 52 - nextCard;
            return cardsLeft;
        }
        /// <summary>
        /// Deal a card
        /// </summary>
        /// <returns>A delt card</returns>
        public Card DealACard()
        {
            int newCardNum = ran.Next(52);           
            Card deltCard = deck[newCardNum];          
            nextCard += nextCard;            
            if (nextCard > 52)
            {                           
                nextCard = 0;                           
            }
            return deltCard;
        }
        /// <summary>
        /// Deal a hand
        /// </summary>
        /// <param name="handSize"></param>
        /// <returns>a delt hand</returns>
        public Hand DealAHand(int handSize) { 
            Hand hand = new Hand(handSize);
            for (int i = 0; i < handSize; i++)
            {
                hand.AddCard(DealACard());
            } 
            return hand;
        }
        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>ToString info on Deck</returns>
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Lab 1 - Java to C#                                                                                  
//  File Name:      Hand.cs
//  Description:    Hand class to construct a hand of cards
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
    /// Hand class
    /// </summary>
    class Hand
    {
        /// <summary>
        /// Size of hand
        /// </summary>
        private int HandSize { get; set; }
        /// <summary>
        /// Size of cards in hand
        /// </summary>
        private int CardsInHand { get; set; }
        /// <summary>
        /// Collection of Hands
        /// </summary>
        private Card[] HandOfCards { get; set; }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Hand()
        {
            HandOfCards = new Card[HandSize];
            CardsInHand = HandSize;
            HandSize = 5;
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="handSize"></param>
        public Hand(int handSize)
        {
            HandOfCards = new Card[handSize];
            this.HandSize = handSize;
            CardsInHand = handSize;
        }
        /// <summary>
        /// Deep copy constructor
        /// </summary>
        /// <param name="handIn"></param>
        public Hand(Hand handIn)
        {
            for (int i = 0; i < HandOfCards.Length; i++)
            {
                this.HandOfCards[i] = handIn.HandOfCards[i];
            }

        }
        /// <summary>
        /// Add card
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {
            this.HandOfCards[CardsInHand - 1] = card;
            CardsInHand--;
        }
        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>ToString info on Hand</returns>
        public override String ToString()
        {
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < HandSize; i++)
            {
                str.AppendLine(HandOfCards[i].ToString());
            }
            return str.ToString();
        }
    }

}
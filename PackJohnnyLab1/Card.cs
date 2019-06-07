//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Lab 1 - Java to C#                                                                                  
//  File Name:      Card.cs
//  Description:    Constructs a card
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
    /// Card Class
    /// </summary>
    class Card
    {
        /// <summary>
        /// Face enum property
        /// </summary>
        private Face FACE { get; set; }
        /// <summary>
        /// Suit enum property
        /// </summary>
        private Suit SUIT { get; set; }
        /// <summary>
        /// Defualt constructor
        /// </summary>
        public Card()
        {
            this.FACE = FACE;
            this.SUIT = SUIT;
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="n">Used to give amount for each enum</param>
        public Card(int n)
        {
            FACE = (Face) (n % 13);
            SUIT = (Suit) (n % 4);
        }
        /// <summary>
        /// Deep Copy Constructor
        /// </summary>
        /// <param name="cardIn"></param>
        public Card(Card cardIn)
        {
            FACE = cardIn.FACE;
            SUIT = cardIn.SUIT;
        }
        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns></returns>
        public  override String ToString()
        {
            String str = $"\tThe {FACE} of {SUIT}";
            return str;
        }
    }
}

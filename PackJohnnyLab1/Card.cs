//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                              
//  Project:        Lab 1 - Java to C#                                                                                  
//  File Name:      Card.cs
//  Description:    Card Class 
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
        private Face EnumFace { get; set; }
        /// <summary>
        /// Suit enum property
        /// </summary>
        private Suit EnumSuit { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Card()
        {
            EnumSuit = Suit.SPADES;
            EnumFace = Face.ACE;
        }
        /// <summary>
        /// Parameterized Contructor
        /// </summary>
        /// <param name="n">Amt needed</param>
        public Card(int n)
        {
            EnumFace = (Face)(n % 13);
            EnumSuit = (Suit)(n % 4);
        }
        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="existingCard"></param>
        public Card(Card existingCard)
        {
            EnumFace = existingCard.EnumFace;
            EnumSuit = existingCard.EnumSuit;
        }
        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns>The FACE of SUIT</returns>
        public override string ToString()
        {
            return $"\tThe {EnumFace} of {EnumSuit}";
        }
    }
}

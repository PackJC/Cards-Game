using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Hand
    {

        private int HandSize { get; set; }
        private int CardsInHand { get; set; }
        private Card[] HandOfCards { get; set; }
       
        public Hand()
        {
            HandOfCards = new Card[52];
            CardsInHand = 0;
            HandSize = 5;
        }
        
        public Hand(int handSize)
        {
            HandOfCards = new Card[handSize];
            this.HandSize = handSize;
        }
        
        public Hand(Hand handIn)
        {
            for (int i = 0; i < HandOfCards.Length; i++)
            {
                this.HandOfCards[i] = handIn.HandOfCards[i];
            }

        }

        public void AddCard(Card card)
        {
            if (CardsInHand >= HandSize)
            {
                Card[] tempCard = new Card[HandOfCards.Length];
                for (int i = 0; i < CardsInHand; i++)
                {
                    tempCard[i] = HandOfCards[i];
                    HandOfCards = tempCard;
                }
            }
        }

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

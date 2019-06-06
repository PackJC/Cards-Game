using System;
using System.Text;

namespace Lab1
{
    class Deck
    {

        private int nextCard;
        private Card[] deck = new Card[52];

        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                deck[i] = new Card(i);
            }
        }

        public Deck(Deck existingDeck)
        {
            for (int i = 0; i < 52; i++)
            {
                this.deck[i] = existingDeck.deck[i];
            }
        }


        public void Shuffle()
        {
            Random ran = new Random();
            int ranNum = ran.Next(52);
            for (int i = 0; i < 52; i++)
            {
                Card mixedCard = deck[ranNum];
                deck[ranNum] = deck[i];
                deck[i] = mixedCard;
            }
            nextCard = 0;
        }


        public override String ToString()
        {
            StringBuilder str = new StringBuilder("");
            for (int i = 0; i < 52; i++)
            {
                str.AppendLine(deck[i].ToString());
            }
            return str.ToString();
        }


        public int CardsLeft()
        {
            int cardsLeft = 52 - nextCard;
            return cardsLeft;
        }


        public Card DealACard()
        {
            Random ran = new Random();                  
            int newCardNum = ran.Next(52);           
            Card deltCard = deck[newCardNum];          
            nextCard = nextCard + nextCard;            
            if (nextCard > 52)
            {                           
                nextCard = 0;                           
            }
            return deltCard;
        }

        public String DealAHand(int handSize)
        {
            String dealStr = ""; 				
            for (int i = 0; i < handSize; i++)
            {
                dealStr += deck[i].ToString() + "\n"; 
            } 
            return dealStr;
        }


    }
}

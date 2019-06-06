using System;

namespace Lab1
{
    class Card
    {

        private Face FACE { get; set; }
        private Suit SUIT { get; set; }


        public Card()
        {
            this.FACE = FACE;
            this.SUIT = SUIT;
        }

        public Card(int n)
        {
            FACE = (Face) (n % 13);
            SUIT = (Suit) (n % 4);
        }

        public  override String ToString()
        {
            String str = $"The {FACE} of {SUIT}!";
            return str;
        }
    }
}

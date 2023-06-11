using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd6.BL
{
    public class Card
    {
        public int Suit;
        public int Value;
     
        public Card(int Suit, int Value)
        {
       
            this.Suit = Suit;
            this.Value = Value;
        }
        public string getSuitAsString()
        {
            if (Suit == 1)
            {
                return "clubs";
            }
            else if (Suit == 2)
            {

                return "diamonds";

            }
            else if (Suit == 3)
            {
                return "heart";


            }
            else if (Suit == 3)
            {

                return "spades";

            }
            else
            {
                return "Not Exit";
            }

          
        }
        public string getValueAsString()
        {
            if (Value == 1)
            {
                return "Ace";
            }
            else if (Value>=2&&Value<=10)
            {
                return Value.ToString();
            }
            else if(Value==11)
            {
                return "Jack";
            }
            else if (Value == 12)
            {
                return "Queen";
            }
            else if(Value==13)
            {
                return "King";
            }
            else
            {
                return "Wrong Value";
            }
        }
        public string toString()
        {
 
            return getSuitAsString()+ "of"+ getValueAsString();

        }
    }
}

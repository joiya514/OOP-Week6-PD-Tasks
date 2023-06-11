using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd6.BL
{
    class Deck
    {
        List<Card> cards;
        public Deck()
        {
            for(int suits=1;suits<=4;suits++)
            {
                for(int values=1;values<=13;values++)
                {
                    Card card = new Card(suits, values);
                    cards.Add(card);
                    
                }
            }
        }
        public void shuffle()
        {
            cards.Clear();
            for (int suits = 4; suits >= 1; suits--)
            {
                for (int values = 13; values >= 1; values--)
                {
                    Card card = new Card(suits, values);
                    cards.Add(card);

                }
            }

        }c
    public Card DealCard()
        {
            Card obj = new Card();
            return cards.
        }

    }

}

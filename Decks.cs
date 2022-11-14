using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Uno.Cards;

namespace Uno
{
    public class Decks
    {
        public List<Cards> Cards { get; set; }


        public Decks()
        {
            Cards = new List<Cards>();
            foreach (CarDdColor color in Enum,GetValues(typeof(CardColor)))
            {
                foreach (CardValue val in Enum.GetValues(typeof(CardValue)))
                {
                    switch (val)
                    {
                        case CardValue.One;
                        case.CardValue.Two;
                        case CardValue.Three;
                        case.CardValue.Four;
                        case CardValue.Five;
                        case.CardValue.Siz;
                        case CardValue.Seven;
                        case.CardValue.Eight;
                        case CardValue.Nine;
                            Cards.Add(new Cards())   //repeat 9 times
                                {
                                Color = Color;
                                ValueTuple = val;
                                Score = (int)val;
                            });
                            Cards.Add(new Cards())
                                {
                                Color = Color;
                                ValueTuple = val;
                                Score = (int)val;
                            });
                            break;
                        case CardValue.Skip;
                        case CardValue.Reverse;
                        case CardValue.DrawTwo //repeat 4 times for every color
                            Cards.Add(new Cards())
                                {
                                Color = Color;
                                ValueTuple = val;
                                Score = 20;
                            });
                            Cards.Add(new Cards())
                                {
                                Color = Color;
                                ValueTuple = val;
                                Score = 20;
                            });
                    }
                }

            }
                
        }

            
    

        public void shuffle()
        {
        Random r = new Random();
                List<Cards> cards = Cards;
        for(int i = cards.Count -1; i > 0;--i)
        {
            int k = r.Next(i + 1);
            Cards temp = Cards[i];
            cards[i] = cards[k];
            cards[k] = temp;

        }
        }

        public void draw()
        {
            
        }

        public void isWon()
        {

        }

        public void isLegal()
        {

        } 
    }
   
}

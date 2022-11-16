using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Uno.Card;

namespace Uno
{
    public class Decks
    {
         List<Card> Cards { get; set; }


        public Decks()
        {
            Cards = new List<Card>();
            foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
            {
                if (color != CardColor.Wild)
                { //Wild cards don't have a color
                    foreach (CardValue val in Enum.GetValues(typeof(CardValue)))
                    {
                        switch (val)
                        {
                            case CardValue.One:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Two:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Three:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Four:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Five:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Six:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Seven:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Eight:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Nine:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = (int)val,
                                });
                                break;
                            case CardValue.Skip:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = 20,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = 20,
                                });
                                break;
                            case CardValue.Reverse:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = 20,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = 20,
                                });
                                break;
                            case CardValue.DrawTwo:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = 20,
                                });
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = 20,
                                });
                                break;
                            case CardValue.Zero:
                                Cards.Add(new Card()
                                {
                                    Color = color,
                                    Value = val,
                                    Score = 0
                                });
                                break;
                        }
                    }

                }
                else
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        Cards.Add(new Card()
                        {
                            Color = color,
                            Value = CardValue.Wild,
                            Score = 50
                        });
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        Cards.Add(new Card()
                        {
                            Color = color,
                            Value = CardValue.DrawFour,
                            Score = 50
                        });
                    }
                }

            }
        }




        public void shuffle()
        {
            Random r = new Random();
            List<Card> cards = Cards;
            for (int i = cards.Count - 1; i > 0; --i)
            {
                int k = r.Next(i + 1);
                Card temp = Cards[i];
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

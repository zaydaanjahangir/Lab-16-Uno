using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{ 
    internal class Cards
    {
        public CardColor Color { get; set; }
        public CardValue Value { get; set; }
        public int score { get; set; }

        public enum CardColor
        {
            Red,
            Green,
            Blue,
            Yellow,
            Wild,
        }

        public enum CardValue
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            DrawTwo,
            DrawFour,
            Wild,
        }

    } 
    
}

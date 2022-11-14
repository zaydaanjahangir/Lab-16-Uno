using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Uno
    {
        public CardDeck DrawPile { get; set; }
        public List<Cards> DiscardPile { get; set; }
    }
}

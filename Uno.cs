using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
public class Uno
{
    public List<Player> Players { get; set; }
    public Decks DrawPile { get; set; }
    public List<Card> DiscardPile { get; set; }
}
}

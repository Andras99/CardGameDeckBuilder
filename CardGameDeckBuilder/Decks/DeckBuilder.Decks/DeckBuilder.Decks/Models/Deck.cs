using DeckBuilder.Collection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder.Decks.Models
{
    public class Deck
    {
        public string Name { get; set; }
        public Game Game { get; set; }

        public override string ToString() => this.Name;
    }
}

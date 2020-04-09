using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder.Collection.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => this.Name;
    }
}

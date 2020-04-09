using DeckBuilder.Collection.Models;
using DeckBuilder.Decks.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckBuilder.Decks.ViewModels
{
    public class CreateDeckViewModel : BindableBase
    {
        public ObservableCollection<Deck> Decks { get; set; }

        public CreateDeckViewModel()
        {
            Decks = SampleDecks();
        }

        private ObservableCollection<Deck> SampleDecks()
        {
            ObservableCollection<Deck> decks = new ObservableCollection<Deck>()
            {
                new Deck() {Game = new Game() {Id = 1, Name = "A Game of Thrones LCG"}, Name = "Baratheon Test Deck"},
                new Deck() {Game = new Game() {Id = 2, Name = "Android:Netrunner LCG"}, Name = "Jinteki Corp Deck"}
            };

            return decks;
        }
    }
}

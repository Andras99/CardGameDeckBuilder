using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameDeckBuilder.Core.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public string Title { get; } = "Deck Building Application";
    }
}

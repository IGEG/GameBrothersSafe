using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBrothersSafe.ViewModels
{
    internal class ItemViewModel: ObservableObject
    {
        public ItemViewModel(string str)
        {
            Text = str;

        }

        private string _text;
        public string Text
        {
            get => _text;
            set=>SetProperty(ref _text, value);
        }
    }
}

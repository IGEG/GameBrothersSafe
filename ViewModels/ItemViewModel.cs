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

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is ItemViewModel)
            {
                ItemViewModel item = (ItemViewModel)obj;
                return item._text == _text;
            }
            else
            {
                return false;
            }
        }
    }
}

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
            Guid = Guid.NewGuid();
        }

        private string _text;
        public string Text
        {
            get => _text;
            set=>SetProperty(ref _text, value);
        }
        private Guid Guid { get; set; }



        public override int GetHashCode()
        {
            return Guid.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is ItemViewModel)
            {
                ItemViewModel item = (ItemViewModel)obj;
                return item.Guid == Guid;
            }
            else
            {
                return false;
            }
        }
    }
}

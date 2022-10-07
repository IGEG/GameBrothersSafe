using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GameBrothersSafe.ViewModels
{
    internal class EasyGameViewModel : ObservableObject
    {
        public EasyGameViewModel()
        {
            
            ListItems = new List<List<ItemViewModel>>();
            var rand = new Random();
            string[] handle = {"|","--" };
        
            for (int i = 0; i < 3; i++)
            {
                ListItems.Add(new List<ItemViewModel>());

                for (int j = 0; j < 3; j++)
                {
                    int index = rand.Next(handle.Length);
                    ListItems[i].Add(new ItemViewModel(handle[index]));
                }
            }
            OnPropertyChanged(nameof(ListItems));
            ClickCommand = new RelayCommand<ItemViewModel>(Click);

        }

        private List<List<ItemViewModel>> _listItems;
        public List<List<ItemViewModel>> ListItems { get=> _listItems; set=> SetProperty(ref _listItems, value);}

        private ICommand _clickCommand;
        public ICommand ClickCommand { get =>_clickCommand; set =>SetProperty(ref _clickCommand, value);}

        private void Click(ItemViewModel item)
        {
            ListItems[0][0].Text = "555";

        }
    }

    
}

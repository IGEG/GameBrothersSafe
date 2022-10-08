using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GameBrothersSafe.ViewModels
{
    internal class EasyGameViewModel : ObservableObject
    {
        public EasyGameViewModel()
        {
            Capasity = 3;
            ListItems = new List<List<ItemViewModel>>();
            LoadRandomItems(ListItems, Capasity);
            OnPropertyChanged(nameof(ListItems));
            ClickCommand = new RelayCommand<ItemViewModel>(Click);
        }
        public int Capasity { get; private set; }

        private List<List<ItemViewModel>> _listItems;
        public List<List<ItemViewModel>> ListItems { get=> _listItems; set=> SetProperty(ref _listItems, value);}

        private ICommand _clickCommand;
        public ICommand ClickCommand { get =>_clickCommand; set =>SetProperty(ref _clickCommand, value);}

        private void Click(ItemViewModel item)
        {
           var str = ChangeTextInButton(item);
           var tp = ListItems.CoordinatesOf<ItemViewModel>(item);
           ChangeTextInAllButton(tp.Item1, tp.Item2, Capasity);
           var check = CheckFinish(item, Capasity, ListItems);
           if (check)
           {
                MessageBox.Show("finish");
           }
        }

        private void LoadRandomItems(List<List<ItemViewModel>> items, int num)
        {
            var rand = new Random();
            string[] handle = { "|", "--" };

            for (int i = 0; i < num; i++)
            {
                items.Add(new List<ItemViewModel>());

                for (int j = 0; j < num; j++)
                {
                    int index = rand.Next(handle.Length);
                    items[i].Add(new ItemViewModel(handle[index]));
                }
            }

        }

        private string ChangeTextInButton(ItemViewModel item)
        {
            var str = item.Text;
            if (str == "|")
            {
                str = "--";
            }
            else
            {
                str = "|";
            }
            item.Text = str;
            return str;
        }
        private void ChangeTextInAllButton(int x, int y, int Capasity)
        {

            for (int i = 0; i < Capasity; i++)
            {
                var indexX = ListItems.IndexOf(ListItems[i]);

                for (int j = 0; j < Capasity; j++)
                {
                    var indexY = ListItems[i].IndexOf(ListItems[i][j]);
                    if (x == indexX || y == indexY)
                    {
                        ListItems[i][j].Text = ChangeTextInButton(ListItems[i][j]);
                    }

                }
            }

        }

        private bool CheckFinish(ItemViewModel item,int Capasity, List<List<ItemViewModel>> ListItems)
        {
            string str = item.Text;

            for (int i = 0; i < Capasity; i++)
            {
                for (int j = 0; j < Capasity; j++)
                {
                    if (str != ListItems[i][j].Text)
                        return false;
                   
                }
            }
            return true;
        }

    }
 
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GameBrothersSafe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GameBrothersSafe.ViewModels
{
    internal class AverageGameViewModel : ObservableObject, IGameModel
    {
        public AverageGameViewModel()
        {
            Capasity = 4;
            ListItems = new List<List<ItemViewModel>>();
            LoadRandomItems(ListItems, Capasity);
            OnPropertyChanged(nameof(ListItems));
            ClickCommand = new RelayCommand<ItemViewModel>(Click);
            CloseCommand = new RelayCommand<Window>(this.Close);
        }
        public int Capasity { get;  set; }

        private List<List<ItemViewModel>> _listItems;
        public List<List<ItemViewModel>> ListItems { get => _listItems; set => SetProperty(ref _listItems, value); }

        private ICommand _clickCommand;
        public ICommand ClickCommand { get => _clickCommand; set => SetProperty(ref _clickCommand, value); }

        public ICommand CloseCommand { get; private set; }

        private void Close(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        private void Click(ItemViewModel item)
        {

            var tp = ListItems.CoordinatesOf<ItemViewModel>(item);
            ChangeTextInAllButton(tp.Item1, tp.Item2, Capasity);
            var check = CheckFinish(item, Capasity, ListItems);
            if (check)
            {
                FinishWindow finish = new FinishWindow();
                finish.Show();
                this.Close(App.Current.Windows[0]);
            }
        }

        public void LoadRandomItems(List<List<ItemViewModel>> ListItems, int Capasity)
        {
            var rand = new Random();
            string[] handle = { "Img/handle.png", "Img/verticalhandle.png" };

            for (int i = 0; i < Capasity; i++)
            {
                ListItems.Add(new List<ItemViewModel>());

                for (int j = 0; j < Capasity; j++)
                {
                    int index = rand.Next(handle.Length);
                    ListItems[i].Add(new ItemViewModel(handle[index]));
                }
            }
        }

        public string ChangeTextInButton(ItemViewModel item)
        {
            var str = item.Text;
            if (str == "Img/handle.png")
            {
                str = "Img/verticalhandle.png";
            }
            else
            {
                str = "Img/handle.png";
            }
            item.Text = str;
            return str;
        }


        public void ChangeTextInAllButton(int x, int y, int Capasity)
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

       
        public bool CheckFinish(ItemViewModel item, int Capasity, List<List<ItemViewModel>> ListItems)
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

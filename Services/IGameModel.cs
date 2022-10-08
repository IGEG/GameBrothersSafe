using GameBrothersSafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace GameBrothersSafe.Services
{
     interface IGameModel
    {
          //задаем размер массива
        int Capasity { get; set; }

          //двухмерный массив (List<List<Т>>)
        List<List<ItemViewModel>> ListItems { get; set; }

          //рандомно записываем массив данными
        void LoadRandomItems(List<List<ItemViewModel>> ListItems, int Capasity);

          //метод смены рисунка на 1 кнопке
        string ChangeTextInButton(ItemViewModel item);

          //метод смены русинков на кнопках по горизонтали(х) и вертикали(у) 
        void ChangeTextInAllButton(int x, int y, int Capasity);

          //проверка на выполнение условия задания(все рукоятки вертикально или горизонтально)
        bool CheckFinish(ItemViewModel item, int Capasity, List<List<ItemViewModel>> ListItems);


    }
}

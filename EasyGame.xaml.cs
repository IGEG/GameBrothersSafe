using GameBrothersSafe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameBrothersSafe
{
    public partial class EasyGame : Window
    {
        public EasyGame()
        {
            InitializeComponent();
            var vm = new EasyGameViewModel();
            easyGameWindow.DataContext = vm;
        }
    }
}

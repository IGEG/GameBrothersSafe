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
    /// <summary>
    /// Interaction logic for DifficultGame.xaml
    /// </summary>
    public partial class DifficultGame : Window
    {
        public DifficultGame()
        {
            InitializeComponent();
            var vm = new DifficultGameViewModel();
            difficultGameWindow.DataContext = vm;
        }
    }
}

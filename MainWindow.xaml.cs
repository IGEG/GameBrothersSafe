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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameBrothersSafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Difficult_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Average_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Easy_Button_Click(object sender, RoutedEventArgs e)
        {
         
            EasyGame easyGame = new EasyGame();
            easyGame.Show();
            this.Close();
        }
    }
}

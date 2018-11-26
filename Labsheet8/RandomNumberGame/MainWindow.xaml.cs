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

namespace RandomNumberGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        int num1, num2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void guessBtn_Click(object sender, RoutedEventArgs e)
        {
            num2 = rand.Next(0, 21);
            if (biggerRadioBtn.IsChecked == true)
            {

            }
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = rand.Next(0, 21);
            initialNumberTxtBx.Text = num1.ToString();
        }

    }
}

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

namespace OddEven
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

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = numberTxt.Text;
            int num;
            if (input.Equals(""))
            {
                msgTxbk.Foreground = Brushes.YellowGreen;
                msgTxbk.Text = "The input box is empty though...";
                return;
            }
            else if (int.TryParse(input, out num))
            {
                if (num % 2 == 0)
                {
                    msgTxbk.Foreground = Brushes.CornflowerBlue;
                    msgTxbk.Text = "Number is even.";
                }
                else
                {
                    msgTxbk.Foreground = Brushes.Purple;
                    msgTxbk.Text = "Number is odd.";
                }
            }
            else
            {
                msgTxbk.Foreground = Brushes.Red;
                msgTxbk.Text = "Try to input a number next time.";
            }
            
            
        }

        private void numberTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            numberTxt.Clear();
        }
    }
}

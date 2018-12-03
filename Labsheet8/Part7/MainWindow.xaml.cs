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

namespace Part7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string direction;
        int amount = 10;
        Random rand = new Random();
        string[] warnings = new string[] { "wow","much doge", "so awed", "just dance", "much dance" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void moveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!moveBtn.Content.Equals("Move!"))
            {
                moveBtn.Content = "Move!";
            }
            direction = directionTxBx.Text;
            switch (direction)
            {
                case "up":
                    
                    break;

                case "down":
                    dogeImg.Margin.Top.Equals(+amount);
                    break;

                case "left":
                    dogeImg.Margin.Left.Equals(-amount);
                    break;

                case "right":
                    dogeImg.Margin.Left.Equals(+amount);
                    break;

                default:
                    warningTxBl.Text = "Read the instructions again and use only lower case letters";
                    break;
            }
        }

        private void dogeImg_MouseEnter(object sender, MouseEventArgs e)
        {
            warningTxBl.Text = warnings[rand.Next(0,5)];
        }

        private void dogeImg_MouseLeave(object sender, MouseEventArgs e)
        {
            warningTxBl.Text = "";
        }
    }
}

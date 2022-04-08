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

namespace _007_wpf_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            chessBoard.Rows = 8;
            chessBoard.Columns = 8;

            for(int i = 0; i < 64/2; i++)
            {
                if((i/4)%2 == 0)
                {
                    Rectangle r1 = new Rectangle();
                    r1.Fill = Brushes.Gold;
                    chessBoard.Children.Add(r1);

                    Rectangle r2 = new Rectangle();
                    r2.Fill = Brushes.Beige;
                    chessBoard.Children.Add(r2);
                }
                else
                {
                    Rectangle r1 = new Rectangle();
                    r1.Fill = Brushes.Beige;
                    chessBoard.Children.Add(r1);

                    Rectangle r2 = new Rectangle();
                    r2.Fill= Brushes.Gold;
                    chessBoard.Children.Add(r2);
                }
            }
        }
    }
}

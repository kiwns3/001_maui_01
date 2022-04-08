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

namespace _007_wpf_01
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

        private void txtHello_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("TextBlock Clicked");

            if (grid1.Background == Brushes.Aqua)
                grid1.Background = Brushes.PowderBlue;
            else
                grid1.Background = Brushes.Aqua;
        }
    }
}

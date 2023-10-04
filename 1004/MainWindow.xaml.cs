using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace _1004
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void run_MouseEnter1(object sender, MouseEventArgs e)
        {
            popText.IsOpen = true;
        }
        private void run_MouseEnter2(object sender, MouseEventArgs e)
        {
            popImages.IsOpen = true;
        }
        private void close_Click(object sender, RoutedEventArgs e)
        {
            popText.IsOpen = false;
            popImages.IsOpen = false;
        }
    }
}

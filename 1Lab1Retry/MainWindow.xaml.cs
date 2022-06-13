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

namespace _1Lab1Retry
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            Silg rashet = new Silg(double.Parse(Speed.Text), double.Parse(Time.Text), double.Parse(Sila.Text));
            Result.Text = rashet.Rashet().ToString();
        }
    }
}

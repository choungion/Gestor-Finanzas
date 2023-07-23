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

namespace GestorFinanzas
{
    /// <summary>
    /// Interaction logic for WindowCuentas.xaml
    /// </summary>
    public partial class WindowCuentas : Window
    {
        public WindowCuentas()
        {
            InitializeComponent();
        }
        private MainWindow main;

        public WindowCuentas(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }

        private void ButtonBanco_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEfectivo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRegrear_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            Hide();
        }
    }
}

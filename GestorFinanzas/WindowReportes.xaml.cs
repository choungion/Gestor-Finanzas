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
    /// Interaction logic for WindowReportes.xaml
    /// </summary>
    public partial class WindowReportes : Window
    {
        public WindowReportes()
        {
            InitializeComponent();
        }
        private MainWindow main;

        public WindowReportes(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private void MenuItemTransacciones_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            main.Show();
        }
    }
}

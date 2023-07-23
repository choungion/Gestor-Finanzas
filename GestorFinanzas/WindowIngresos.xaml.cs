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
using static System.Net.Mime.MediaTypeNames;

namespace GestorFinanzas
{
    /// <summary>
    /// Interaction logic for WindowIngresos.xaml
    /// </summary>
    public partial class WindowIngresos : Window
    {
        public WindowIngresos()
        {
            InitializeComponent();
        }
        private MainWindow main;

        public WindowIngresos(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private void ComboBoxCuentas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString() == "Banco")
            {
                Uri imagePath = new Uri("/bank.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen; 
            }
            else if(((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString() == "Efectivo") 
            {
                Uri imagePath = new Uri("/Wallet.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen;
            }
        }
    }
}

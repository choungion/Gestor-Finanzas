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
        private static WindowCuentas Instancia;
        public static WindowCuentas InstanciaCuentas
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowCuentas();
                }
                return Instancia;
            }
        }

        private void ButtonBanco_Click(object sender, RoutedEventArgs e)
        {
            WindowBanco.InstanciaBanco.Show();
            Hide();
        }

        private void ButtonEfectivo_Click(object sender, RoutedEventArgs e)
        {
            WindowEfectivo.InstanciaEfectivo.Show();
            Hide();
        }

        private void ButtonRegrear_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.InstanciaMain.Show();
            Hide();
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

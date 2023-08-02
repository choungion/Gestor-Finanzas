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
            WindowBanco windowBanco = new WindowBanco();
            windowBanco.Show();
            //Hide();
            Close();
        }

        private void ButtonEfectivo_Click(object sender, RoutedEventArgs e)
        {           
            WindowEfectivo windowEfectivo = new WindowEfectivo();
            windowEfectivo.Show();

            //Hide();
            Close();
        }



        // botones de regresar y cerrar ventana
        private void ButtonRegrear_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //MainWindow.InstanciaMain.Show();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
           
        }

        
    }
}

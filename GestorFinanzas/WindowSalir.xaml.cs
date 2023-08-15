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
    /// Interaction logic for WindowSalir.xaml
    /// </summary>
    public partial class WindowSalir : Window
    {
        public WindowSalir()
        {
            InitializeComponent();
        }
        private static WindowSalir Instancia;
        public static WindowSalir InstanciaSalir
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowSalir();
                }
                return Instancia;
            }
        }

        private void ButtonCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            WindowInicioSesion.InstanciaInicioSesion.Show();
            Hide();
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Hide();
        }

        private void ButtonSalir_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

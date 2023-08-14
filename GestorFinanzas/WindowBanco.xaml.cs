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
    /// Interaction logic for WindowBanco.xaml
    /// </summary>
    public partial class WindowBanco : Window
    {
        public WindowBanco()
        {
            InitializeComponent();
            WindowStyle = WindowStyle.None;
        }
        private static WindowBanco Instancia;
        public static WindowBanco InstanciaBanco
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowBanco();
                }
                return Instancia;
            }
        }

        private void VentanaCargada(object sender, EventArgs e)
        {
            Balance.InstanciaBalance.BuscarCuentaBanco("Banco");
            LabelTotal.Content = $"₡ {Balance.InstanciaBalance.MostrarBalanceBanco().ToString()}";
            ListBoxCategoria.ItemsSource = Balance.InstanciaBalance.ObtenerCategorias();
            ListBoxCantidades.ItemsSource = Balance.InstanciaBalance.ObtenerListaBalanceBanco();
            ListBoxFecha.ItemsSource = Balance.InstanciaBalance.ObtenerFecha("Banco");
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ButtonRegresar_Click(object sender, RoutedEventArgs e)
        {
            ListBoxFecha.ItemsSource = new List<string>();
            ListBoxCantidades.ItemsSource = new List<string>();
            ListBoxCategoria.ItemsSource = new List<string>();
            WindowCuentas.InstanciaCuentas.Show();
            Hide();
        }
    }
}

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
    /// Interaction logic for WindowEfectivo.xaml
    /// </summary>
    public partial class WindowEfectivo : Window
    {
        public WindowEfectivo()
        {
            InitializeComponent();
            WindowStyle = WindowStyle.None;
        }
        private static WindowEfectivo Instancia;
        public static WindowEfectivo InstanciaEfectivo
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowEfectivo();
                }
                return Instancia;
            }
        }

        private void VentanaCargada(object sender, EventArgs e)
        {
            Balance.InstanciaBalance.BuscarCuentaEfectivo("Efectivo");
            LabelTotal.Content = $"₡ {Balance.InstanciaBalance.MostrarBalanceEfectivo().ToString()}";
            ListBoxCategoria.ItemsSource = Balance.InstanciaBalance.ObtenerCategorias();
            ListBoxCantidades.ItemsSource = Balance.InstanciaBalance.ObtenerListaBalanceEfectivo();
            ListBoxFecha.ItemsSource = Balance.InstanciaBalance.ObtenerFecha("Efectivo");
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

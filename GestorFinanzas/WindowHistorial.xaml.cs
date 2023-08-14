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
    /// Interaction logic for WindowHistorial.xaml
    /// </summary>
    public partial class WindowHistorial : Window
    {
        public WindowHistorial()
        {
            InitializeComponent();
            WindowStyle = WindowStyle.None;
        }
        private static WindowHistorial Instancia;
        public static WindowHistorial InstanciaHistorial
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowHistorial();
                }
                return Instancia;
            }
        }
        private void MostrarHistorial(string cuenta)
        {
            List<string> categorias = Balance.InstanciaBalance.ObtenerCategorias();

            List<string> fechas = Balance.InstanciaBalance.ObtenerFecha(cuenta);

            List<float> cantidades = new List<float>();
            if (cuenta == "Banco")
            {
                cantidades = Balance.InstanciaBalance.ObtenerListaBalanceBanco();
            }
            else if (cuenta == "Efectivo")
            {
                cantidades = Balance.InstanciaBalance.ObtenerListaBalanceEfectivo();
            }
            for (int i = 0; i < categorias.Count; i++)
            {
                ListBoxCategoria.Items.Add(categorias[i]);
                ListBoxFecha.Items.Add(fechas[i]);
                ListBoxCantidades.Items.Add(cantidades[i]);
            }
        }
        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void VentanaCargada(object sender, EventArgs e)
        {
            Balance.InstanciaBalance.BuscarCuentaBanco("Banco");
            LabelTotal.Content = $"₡ {Balance.InstanciaBalance.MostrarBalanceTotal().ToString()}";
            MostrarHistorial("Banco");

            Balance.InstanciaBalance.BuscarCuentaEfectivo("Efectivo");
            LabelTotal.Content = $"₡ {Balance.InstanciaBalance.MostrarBalanceTotal().ToString()}";
            MostrarHistorial("Efectivo");
        }
        private void ButtonRegresar_Click(object sender, RoutedEventArgs e)
        {
            ListBoxFecha.Items.Clear();
            ListBoxCantidades.Items.Clear();
            ListBoxCategoria.Items.Clear();
            MainWindow.InstanciaMain.Show();
            Hide();
        }
    }
}


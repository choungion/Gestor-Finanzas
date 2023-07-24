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
    /// Interaction logic for WindowTransferir.xaml
    /// </summary>
    public partial class WindowTransferir : Window
    {
        public WindowTransferir()
        {
            InitializeComponent();
        }
        private DateTime FechaSeleccionada;
        private static WindowTransferir Instancia;
        public static WindowTransferir InstanciaTransferir
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowTransferir();
                }
                return Instancia;
            }
        }
        
        private void ComboBoxCuentaOrigen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxCuentaOrigen.SelectedIndex == 0)
            {
                ComboBoxCuentaDestino.SelectedIndex = 1;
            }
            else if (ComboBoxCuentaOrigen.SelectedIndex == 1)
            {
                ComboBoxCuentaDestino.SelectedIndex = 0;
            }
        }
        private void Calendario_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar calendario = (Calendar)sender;
            if (calendario.SelectedDate.HasValue)
            {
                var Fecha = calendario.SelectedDate.Value;
                FechaSeleccionada = calendario.SelectedDate.Value;
                MessageBox.Show($"Fecha Seleccionada: {Fecha.ToShortDateString()}");
                Calendario.Visibility = Visibility.Hidden;
            }
        }
        private void ButtonTransferir_Click(object sender, RoutedEventArgs e)
        {
            Balance.InstanciaBalance.IngresarListaFlujoDinero(float.Parse(TxtBoxCantidad.Text));
            Balance.InstanciaBalance.IngresarListaCuenta(((ComboBoxItem)ComboBoxCuentaDestino.SelectedItem).Content.ToString());
            Balance.InstanciaBalance.IngresarListaCategoria("Transferencia");
            Balance.InstanciaBalance.IngresarListaMeses(FechaSeleccionada.Month);
            Balance.InstanciaBalance.IngresarListaAnual(FechaSeleccionada.Year);
            Balance.InstanciaBalance.IngresarListaDias(FechaSeleccionada.Day);

            Balance.InstanciaBalance.IngresarListaFlujoDinero(float.Parse(TxtBoxCantidad.Text)*-1);
            Balance.InstanciaBalance.IngresarListaCuenta(((ComboBoxItem)ComboBoxCuentaOrigen.SelectedItem).Content.ToString());
            Balance.InstanciaBalance.IngresarListaCategoria("Transferencia");
            Balance.InstanciaBalance.IngresarListaMeses(FechaSeleccionada.Month);
            Balance.InstanciaBalance.IngresarListaAnual(FechaSeleccionada.Year);
            Balance.InstanciaBalance.IngresarListaDias(FechaSeleccionada.Day);

            Balance.InstanciaBalance.BuscarMes(FechaSeleccionada.Month);
            ComboBoxCuentaOrigen.SelectedIndex = -1;
            ComboBoxCuentaDestino.SelectedIndex = -1;
            TxtBoxCantidad.Text = string.Empty;
            Calendario.SelectedDate = null;
            FechaSeleccionada = DateTime.MinValue;
            MainWindow.InstanciaMain.Show();
            Hide();
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.InstanciaMain.Show();
            Hide();
        }
        private void ButtonFechaIngreso_Click(object sender, RoutedEventArgs e)
        {
            Calendario.Visibility = Visibility.Visible;
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

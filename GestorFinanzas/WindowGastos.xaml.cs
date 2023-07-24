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
    public partial class WindowGastos : Window
    {
        public WindowGastos()
        {
            InitializeComponent();
        }
        private DateTime FechaSeleccionada;
        private Balance InstanciaBalance;
        private static WindowGastos Instancia;
        public static WindowGastos InstanciaGastos
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowGastos();
                }
                return Instancia;
            }
        }
        private void ComboBoxCuentas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString() == "Banco")
            {
                Uri imagePath = new Uri("/bank.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen;
            }
            else if (((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString() == "Efectivo")
            {
                Uri imagePath = new Uri("/Wallet.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen;
            }
        }
        private void ButtonFechaGasto_Click(object sender, RoutedEventArgs e)
        {
            Calendario.Visibility = Visibility.Visible;
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
        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow.InstanciaMain.Show();
        }

        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow.InstanciaMain.Show();
            Balance.InstanciaBalance.IngresarListaFlujoDinero(float.Parse(TxtBoxCantidad.Text)*-1);
            Balance.InstanciaBalance.IngresarListaCuenta(((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString());
            Balance.InstanciaBalance.IngresarListaCategoria(((ComboBoxItem)ComboBoxCategorias.SelectedItem).Content.ToString());
            Balance.InstanciaBalance.IngresarListaMeses(FechaSeleccionada.Month);
            Balance.InstanciaBalance.IngresarListaAnual(FechaSeleccionada.Year);
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

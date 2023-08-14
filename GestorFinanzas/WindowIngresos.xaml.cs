using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            WindowStyle = WindowStyle.None;
        }
        private DateTime FechaSeleccionada;
        private Balance InstanciaBalance;
        private static WindowIngresos Instancia;
        bool FlagCantidad = false;
        bool FlagCuentas = false;
        bool FlagFecha = false;
        bool FlagCategoria = false;
        public static WindowIngresos InstanciaIngresos
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowIngresos();
                }
                return Instancia;
            }
        }
        #region Eventos de controladores
        private void ComboBoxCuentas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboBoxCuentas.SelectedIndex == 1)
            {
                Uri imagePath = new Uri("/bank.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen; 
            }
            else if(ComboBoxCuentas.SelectedIndex == 0) 
            {
                Uri imagePath = new Uri("/Wallet.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen;
            }
        }
        private void ButtonFechaIngreso_Click(object sender, RoutedEventArgs e)
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
            TxtBoxCantidad.Background = null;
            ComboBoxCuentas.Foreground = Brushes.Black;
            LabelFecha.Foreground = Brushes.Black;
            ComboBoxCategorias.Foreground = Brushes.Black;
            Hide();
            MainWindow.InstanciaMain.Show();
        }

        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {
            string hexLightRed = "#FF0000";
            BrushConverter converter = new BrushConverter();
            Brush RojoClaro = (Brush)converter.ConvertFromString(hexLightRed);
            if (string.IsNullOrEmpty(TxtBoxCantidad.Text))
            {
                TxtBoxCantidad.Background = RojoClaro;
            }
            else if (int.Parse(TxtBoxCantidad.Text) == 0)
            {
                TxtBoxCantidad.Background = RojoClaro;
            }
            else
            {
                TxtBoxCantidad.Background = null;
                FlagCantidad = true;
            }
            if (ComboBoxCuentas.SelectedIndex == 2)
            {
                ComboBoxCuentas.Foreground = RojoClaro;
            }
            else
            {
                ComboBoxCuentas.Foreground = Brushes.Black;
                FlagCuentas = true;
            }
            if (Calendario.SelectedDate.HasValue)
            {
                LabelFecha.Foreground = Brushes.Black;
                FlagFecha = true;
            }
            else
            {
                LabelFecha.Foreground = RojoClaro;
            }
            if (ComboBoxCategorias.SelectedIndex == 4)
            {
                ComboBoxCategorias.Foreground = RojoClaro;
            }
            else
            {
                ComboBoxCategorias.Foreground = Brushes.Black;
                FlagCategoria = true;
            }
            if (FlagCantidad == true && FlagCategoria == true && FlagCuentas == true && FlagFecha == true)
            {
                Balance.InstanciaBalance.IngresarListaUsuarios();
                Balance.InstanciaBalance.IngresarListaFlujoDinero(float.Parse(TxtBoxCantidad.Text));
                Balance.InstanciaBalance.IngresarListaCuenta(((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString());
                Balance.InstanciaBalance.IngresarListaCategoria(((ComboBoxItem)ComboBoxCategorias.SelectedItem).Content.ToString());
                Balance.InstanciaBalance.IngresarListaMeses(FechaSeleccionada.Month);
                Balance.InstanciaBalance.IngresarListaAnual(FechaSeleccionada.Year);
                Balance.InstanciaBalance.IngresarListaDias(FechaSeleccionada.Day);
                Balance.InstanciaBalance.BuscarMes(FechaSeleccionada.Month);
                ComboBoxCuentas.SelectedIndex = 2;
                ComboBoxCategorias.SelectedIndex = 4;
                ImageIcono.Source = null;
                TxtBoxCantidad.Text = string.Empty;
                Calendario.SelectedDate = null;
                FechaSeleccionada = DateTime.MinValue;
                MainWindow.InstanciaMain.Show();
                Hide();
            }
            else
            {
                //MessageBox.Show("Llene todos los campos");
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                e.Cancel = true;
            }
        }
        private void TxtBoxCantidad_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ValoresAceptados = "^[0-9]*\\.?[0-9]*$";
            Regex regex = new Regex(ValoresAceptados);
            if (!regex.IsMatch(TxtBoxCantidad.Text))
            {
                string Texto = TxtBoxCantidad.Text;
                TxtBoxCantidad.Text = Texto.Substring(0, Texto.Length - 1);
                TxtBoxCantidad.CaretIndex = TxtBoxCantidad.Text.Length;
            }
        }
        #endregion
    }
}

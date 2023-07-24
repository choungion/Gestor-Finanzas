using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestorFinanzas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static MainWindow Instancia;
        public MainWindow()
        {
            InitializeComponent();
            LabelCantidadTotal.Content = "₡ " +Balance.InstanciaBalance.MostrarBalanceTotal();
        }
        #region Eventos de controlers
        private void ButtonPeriodo_Click(object sender, RoutedEventArgs e)
        {
            Calendario.Visibility = Visibility.Visible;
            Hide();
        }
        private void Calendario_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {
            Calendario.DisplayMode = CalendarMode.Year;
            Calendario.Visibility = Visibility.Hidden;
        }
        private void Calendario_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {
            DateTime? fecha = e.AddedDate;
            if (fecha.HasValue)
            {
                DateTime selectedMonth = fecha.Value;
                LabelPeriodo.Content = $"{selectedMonth: MMMM yyyy}";
            }
        }
        private void ButtonBalance_Click(object sender, RoutedEventArgs e)
        {
            WindowHistorial.InstanciaHistorial.Show();
            Hide();
        }

        private void ButtonConsultar_Click(object sender, RoutedEventArgs e)
        {
            WindowCuentas.InstanciaCuentas.Show();
            Hide();
        }
        private void MenuItemReportes_Click(object sender, RoutedEventArgs e)
        {
            WindowReportes.InstanciaReportes.Show();
            Hide();
        }
        private void MenuItemIngresos_Click(object sender, RoutedEventArgs e)
        {
            WindowIngresos.InstanciaIngresos.Show();
            Hide();
        }
        private void MenuItemGastos_Click(object sender, RoutedEventArgs e)
        {
            WindowGastos.InstanciaGastos.Show();
            Hide();
        }
        private void MenuItemTransferir_Click(object sender, RoutedEventArgs e)
        {
            WindowTransferir.InstanciaTransferir.Show();
            Hide();
        }
        #endregion
        public static MainWindow InstanciaMain
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new MainWindow();
                }
                return Instancia;
            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

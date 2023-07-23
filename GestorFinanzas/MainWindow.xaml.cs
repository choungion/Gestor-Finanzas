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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestorFinanzas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Eventos de controlers
        private void ButtonPeriodo_Click(object sender, RoutedEventArgs e)
        {
            Calendario.Visibility = Visibility.Visible;
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
        }

        private void ButtonConsultar_Click(object sender, RoutedEventArgs e)
        {
            AbrirConsultaCuentas();
        }
        private void MenuItemReportes_Click(object sender, RoutedEventArgs e)
        {
            AbrirReportes();
        }
        private void MenuItemIngresos_Click(object sender, RoutedEventArgs e)
        {
            AbrirIngresos();
        }
        private void MenuItemGastos_Click(object sender, RoutedEventArgs e)
        {
        }
        private void MenuItemTransferir_Click(object sender, RoutedEventArgs e)
        {
        }
        #endregion
        #region Metodos para pasar las instancias de las ventanas como parametros
        private void AbrirConsultaCuentas()
        {
            WindowCuentas CuentasWindow = new WindowCuentas(this);
            CuentasWindow.Show();
            Hide();
        }
        private void AbrirReportes()
        {
            WindowReportes ReportesWindow = new WindowReportes(this);
            ReportesWindow.Show();
            Hide();
        }
        private void AbrirIngresos()
        {
            WindowIngresos IngresosWindow = new WindowIngresos(this);
            IngresosWindow.Show();
            Hide();
        }
        #endregion
    }
}

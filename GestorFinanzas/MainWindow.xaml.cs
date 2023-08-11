using System;

using System.Windows;
using System.Windows.Controls;


namespace GestorFinanzas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instancia;
        private DateTime? fecha = DateTime.Now;
        DateTime FechaSeleccionada = DateTime.Now;

        public static int indicePERSONA_APP;
        public DATOS_PERSONA persona;


        public MainWindow()
        {
            InitializeComponent();
            persona = REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[indicePERSONA_APP];

            LBL_principal.Content = "BIENVENIDO USUARIO>>> "+
             persona.get_USUARIO();

           

        }

       

        #region Eventos de controlers
        private void ButtonPeriodo_Click(object sender, RoutedEventArgs e)
        {
            Calendario.Visibility = Visibility.Visible;
        }
        private void Calendario_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {
            Calendario.DisplayMode = CalendarMode.Year;
        }
        private void Calendario_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {
            fecha = e.AddedDate;
            if (fecha.HasValue)
            {
                FechaSeleccionada = fecha.Value;
                LabelPeriodo.Content = $"{FechaSeleccionada: MMMM yyyy}";
                Balance.InstanciaBalance.BuscarMes(FechaSeleccionada.Month);
                LabelGastos.Content = $"₡ {Balance.InstanciaBalance.MostrarGastoMensual()}";
                LabelIngresos.Content = $"₡ {Balance.InstanciaBalance.MostrarIngresoMensual()}";
                LabelBalanceMensual.Content = $"₡ {Balance.InstanciaBalance.MostrarBalanceMensual()}";
                Calendario.Visibility = Visibility.Hidden;
            }
        }

        private void ButtonBalance_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowHistorial windowHistorial = new WindowHistorial();
            windowHistorial.Show();
           
            
        }

        private void ButtonConsultar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowCuentas consulta = new WindowCuentas();
            consulta.Show();   
            //Hide();
            
        }



        private void MenuItemReportes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowReportes windowReportes = new WindowReportes();
            windowReportes.Show();
            //Hide();
            
        }



        private void MenuItemIngresos_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowIngresos window_ingresos = new WindowIngresos();
            WindowIngresos.indicePERSONA_APP = indicePERSONA_APP;
            window_ingresos.Show();

            
            //Hide();
            
        }



        private void MenuItemGastos_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowGastos windowGastos = new WindowGastos();
            windowGastos.Show();
            //Hide();
            
        }



        private void MenuItemTransferir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WindowTransferir windowTransferir = new WindowTransferir();
            windowTransferir.Show();
            //Hide();
           
        }



        private void VentanaCargada(object sender, EventArgs e)
        {

            // persona.transacciones_usuario.BuscarMes(FechaSeleccionada.Month);
            // LabelCantidadTotal.Content = "₡ " + persona.transacciones_usuario.MostrarBalanceTotal().ToString(); ya        
            // LabelGastos.Content = "₡ " + persona.transacciones_usuario.MostrarGastoMensual().ToString();   ya           
            //LabelIngresos.Content = "₡ " + persona.transacciones_usuario.MostrarIngresoMensual().ToString("F0");  ya   
            // LabelBalanceMensual.Content = "₡ " + persona.transacciones_usuario.MostrarBalanceMensual().ToString("F0");

            Balance.InstanciaBalance.BuscarMes(FechaSeleccionada.Month);

            LabelIngresos.Content = "₡ " + Balance.InstanciaBalance.MostrarIngresoMensual().ToString("F0");
            LabelGastos.Content = "₡ "+ Balance.InstanciaBalance.MostrarGastoMensual().ToString("F0");

            LabelCantidadTotal.Content = "₡ " + Balance.InstanciaBalance.MostrarBalanceTotal().ToString("F0");
            LabelBalanceMensual.Content = "₡ " + Balance.InstanciaBalance.MostrarBalanceMensual().ToString("F0");
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

        private void BTN_SALIR(object sender, RoutedEventArgs e)
        {
           this.Close();
           WindowInicioSesion ventana_inicio = new WindowInicioSesion();
           ventana_inicio.Show();
            
        }

        
    }
    

}

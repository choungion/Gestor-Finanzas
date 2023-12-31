﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
        private DateTime? fecha = DateTime.Now;
        DateTime FechaSeleccionada = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
        }
        #region ------------------------------Eventos de controlers-----------------------------------------
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
        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                e.Cancel = true;
                Hide();
                WindowSalir.InstanciaSalir.Show();
            }
        }
        private void VentanaCargada(object sender, EventArgs e)
        {
            Balance.InstanciaBalance.BuscarMes(FechaSeleccionada.Month);
            LabelCantidadTotal.Content = "₡ " + Balance.InstanciaBalance.MostrarBalanceTotal().ToString("F0");
            LabelGastos.Content = "₡ " + Balance.InstanciaBalance.MostrarGastoMensual().ToString("F0");
            LabelIngresos.Content = "₡ " + Balance.InstanciaBalance.MostrarIngresoMensual().ToString("F0");
            LabelBalanceMensual.Content = "₡ " + Balance.InstanciaBalance.MostrarBalanceMensual().ToString("F0");
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button btn = (Button)sender;
            string mensaje = btn.Tag as string;
            btn.ToolTip = mensaje;
        }

        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            string mensaje = mi.Tag as string;
            mi.ToolTip = mensaje;
        }

        #endregion-----------------------Eventos de controladores------------------------------------------
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

    }

}

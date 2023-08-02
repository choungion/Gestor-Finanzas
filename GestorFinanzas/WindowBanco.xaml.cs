using System;
using System.Collections.Generic;

using System.Windows;

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

       

        private void ButtonRegresar_Click(object sender, RoutedEventArgs e)
        {
            ListBoxFecha.ItemsSource = new List<string>();
            ListBoxCantidades.ItemsSource = new List<string>();
            ListBoxCategoria.ItemsSource = new List<string>();
            WindowCuentas cuentas = new WindowCuentas();
            cuentas.Show();
            this.Close();
           
        }
    }
}

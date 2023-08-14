using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for WindowReportes.xaml
    /// </summary>
    /// 
    
    public partial class WindowReportes : Window
    {
        public WindowReportes()
        {
            InitializeComponent();
            WindowStyle = WindowStyle.None;
        }
        private static WindowReportes Instancia;
        private List<string> GastosCategoria = new List<string>();
        private List<string> IngresosCategoria = new List<string>();
        public static WindowReportes InstanciaReportes
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowReportes();
                }
                return Instancia;
            }
        }
        private void MenuItemTransacciones_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.InstanciaMain.Show();
            Hide();
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ComboBoxAno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Balance.InstanciaBalance.BuscarAno(((ComboBoxItem)ComboBoxAno.SelectedItem).Content.ToString());
            #region Obtener los gastos e ingresos por categoria
            float GastoComida = 0;
            float GastoFacturas = 0;
            float GastoTransporte = 0;
            float GastoCompras = 0;
            float GastoRegalos = 0;
            float GastoEducacion = 0;
            float GastoRenta = 0;
            float GastoViajes = 0;
            float IngresoSalario = 0;
            float IngresoInversiones = 0;
            float IngresoRenta = 0;
            float IngresoRegalo = 0;
            for (int i =0; i < Balance.InstanciaBalance.ObtenerCategorias().Count; i++)
            {
                if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Comida")
                {
                    GastoComida = GastoComida + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if(Balance.InstanciaBalance.ObtenerCategorias()[i] == "Facturas")
                {
                    GastoFacturas = GastoFacturas + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Transporte")
                {
                    GastoTransporte = GastoTransporte + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Compras")
                {
                    GastoCompras = GastoCompras + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if(Balance.InstanciaBalance.ObtenerCategorias()[i] == "Regalos")
                {
                    GastoRegalos = GastoRegalos + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if(Balance.InstanciaBalance.ObtenerCategorias()[i] == "Educacion")
                {
                    GastoEducacion = GastoEducacion + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if(Balance.InstanciaBalance.ObtenerCategorias()[i] == "Renta")
                {
                    GastoRenta = GastoRenta + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if(Balance.InstanciaBalance.ObtenerCategorias()[i] == "Viajes")
                {
                    GastoViajes = GastoViajes + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Salario")
                {
                    IngresoSalario = IngresoSalario + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Inversiones")
                {
                    IngresoInversiones = IngresoInversiones + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Renta")
                {
                    IngresoRenta = IngresoRenta + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Regalo")
                {
                    IngresoRegalo = IngresoRegalo + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
            }
            GastosCategoria.Add("Comida: " + GastoComida);
            GastosCategoria.Add("Facturas: " + GastoFacturas);
            GastosCategoria.Add("Transporte: " + GastoTransporte);
            GastosCategoria.Add("Compras: " + GastoCompras);
            GastosCategoria.Add("Regalos: " + GastoRegalos);
            GastosCategoria.Add("Educacion: " + GastoEducacion);
            GastosCategoria.Add("Renta: " + GastoRenta);
            GastosCategoria.Add("Viajes: " + GastoViajes);
            IngresosCategoria.Add("Salario: " + IngresoSalario);
            IngresosCategoria.Add("Inversiones: " + IngresoInversiones);
            IngresosCategoria.Add("Renta: " + IngresoRenta);
            IngresosCategoria.Add("Regalo: " + IngresoRegalo);
            #endregion
        }

        private void VentanaCargada(object sender, EventArgs e)
        {
            Balance.InstanciaBalance.BuscarAno(((ComboBoxItem)ComboBoxAno.SelectedItem).Content.ToString());
            LstBoxGastosCategorias.ItemsSource = GastosCategoria;
            LstBoxIngresosCategorias.ItemsSource = IngresosCategoria;
        }
    }
}

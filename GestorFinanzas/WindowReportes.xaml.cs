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
        private List<string> GastosCuenta = new List<string>();
        private List<string> IngresosCuenta = new List<string>();
        private List<string> GastosMes = new List<string>();
        private List<string> IngresosMes = new List<string>();
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

        private void ComboBoxAno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Balance.InstanciaBalance.BuscarAno(int.Parse((ComboBoxAno.SelectedValue).ToString()));
            FlujoCategoria();
            FlujoCuenta();
            FlujoMes();

            LstBoxGastosCategorias.ItemsSource = new List<string>();
            LstBoxIngresosCategorias.ItemsSource = new List<string>();
            LstBoxGastosCuentas.ItemsSource = new List<string>();
            LstBoxIngresosCuentas.ItemsSource = new List<string>();
            LstBoxGastosMes.ItemsSource = new List<string>();
            LstBoxIngresosMes.ItemsSource = new List<string>();
            LstBoxGastosCategorias.ItemsSource = GastosCategoria;
            LstBoxIngresosCategorias.ItemsSource = IngresosCategoria;
            LstBoxGastosCuentas.ItemsSource = GastosCuenta;
            LstBoxIngresosCuentas.ItemsSource = IngresosCuenta;
            LstBoxGastosMes.ItemsSource = GastosMes;
            LstBoxIngresosMes.ItemsSource = IngresosMes;
        }
        #region Obtener los gastos e ingresos por categoria
        private void FlujoCategoria()
        {
            float GastoComida = 0;
            float GastoFacturas = 0;
            float GastoTransporte = 0;
            float GastoCompras = 0;
            float GastoRegalos = 0;
            float GastoEducacion = 0;
            float GastoRenta = 0;
            float GastoViajes = 0;
            float GastoTransferencia = 0;
            float IngresoSalario = 0;
            float IngresoInversiones = 0;
            float IngresoRenta = 0;
            float IngresoRegalo = 0;
            float IngresoTransferencia = 0;

            GastosCategoria.Clear();
            IngresosCategoria.Clear();

            for (int i = 0; i < Balance.InstanciaBalance.ObtenerCategorias().Count; i++)
            {
                if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Comida")
                {
                    GastoComida = GastoComida + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Facturas")
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
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Regalos")
                {
                    GastoRegalos = GastoRegalos + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Educacion")
                {
                    GastoEducacion = GastoEducacion + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Renta")
                {
                    GastoRenta = GastoRenta + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Viajes")
                {
                    GastoViajes = GastoViajes + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Transferencia" && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoTransferencia = GastoTransferencia + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
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
                else if (Balance.InstanciaBalance.ObtenerCategorias()[i] == "Transferencia" && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoTransferencia = IngresoTransferencia + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
            }
            GastosCategoria.Add("Comida: ₡" + GastoComida);
            GastosCategoria.Add("Facturas: ₡" + GastoFacturas);
            GastosCategoria.Add("Transporte: ₡" + GastoTransporte);
            GastosCategoria.Add("Compras: ₡" + GastoCompras);
            GastosCategoria.Add("Regalos: ₡" + GastoRegalos);
            GastosCategoria.Add("Educacion: ₡" + GastoEducacion);
            GastosCategoria.Add("Renta: ₡" + GastoRenta);
            GastosCategoria.Add("Viajes: ₡" + GastoViajes);
            GastosCategoria.Add("Transferencia: ₡" + GastoTransferencia);
            IngresosCategoria.Add("Salario: ₡" + IngresoSalario);
            IngresosCategoria.Add("Inversiones: ₡" + IngresoInversiones);
            IngresosCategoria.Add("Renta: ₡" + IngresoRenta);
            IngresosCategoria.Add("Regalo: ₡" + IngresoRegalo);
            IngresosCategoria.Add("Transferencia: ₡" + IngresoTransferencia);
        }
        #endregion
        #region Obtener los gastos e ingresos por cuenta
        private void FlujoCuenta()
        {
            float GastoEfectivo = 0;
            float GastoBanco = 0;
            float IngresoEfectivo = 0;
            float IngresoBanco = 0;

            GastosCuenta.Clear();
            IngresosCuenta.Clear();

            for (int i = 0; i < Balance.InstanciaBalance.ObtenerCuentas().Count; i++)
            {
                if (Balance.InstanciaBalance.ObtenerCuentas()[i] == "Efectivo" && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoEfectivo = GastoEfectivo + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCuentas()[i] == "Banco" && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoBanco = GastoBanco + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCuentas()[i] == "Efectivo" && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoEfectivo = IngresoEfectivo + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerCuentas()[i] == "Banco" && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoBanco = IngresoBanco + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
            }
            GastosCuenta.Add("Efectivo: ₡" + GastoEfectivo);
            GastosCuenta.Add("Banco: ₡" + GastoBanco);
            IngresosCuenta.Add("Efectivo: ₡" + IngresoEfectivo);
            IngresosCuenta.Add("Banco: ₡" + IngresoBanco);
        }
        #endregion
        #region Obtener los gastos e ingresos por mes
        private void FlujoMes()
        {
            float GastoEnero = 0;
            float GastoFebrero = 0;
            float GastoMarzo = 0;
            float GastoAbril = 0;
            float GastoMayo = 0;
            float GastoJunio = 0;
            float GastoJulio = 0;
            float GastoAgosto = 0;
            float GastoSeptiembre = 0;
            float GastoOctubre = 0;
            float GastoNoviembre = 0;
            float GastoDiciembre = 0;
            float IngresoEnero = 0;
            float IngresoFebrero = 0;
            float IngresoMarzo = 0;
            float IngresoAbril = 0;
            float IngresoMayo = 0;
            float IngresoJunio = 0;
            float IngresoJulio = 0;
            float IngresoAgosto = 0;
            float IngresoSeptiembre = 0;
            float IngresoOctubre = 0;
            float IngresoNoviembre = 0;
            float IngresoDiciembre = 0;

            GastosMes.Clear();
            IngresosMes.Clear();

            for (int i = 0; i < Balance.InstanciaBalance.ObtenerMeses().Count; i++)
            {
                if (Balance.InstanciaBalance.ObtenerMeses()[i] == 1 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoEnero = GastoEnero + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 2 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoFebrero = GastoFebrero + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 3 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoMarzo = GastoMarzo + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 4 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoAbril = GastoAbril + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 5 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoMayo = GastoMayo + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 6 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoJunio = GastoJunio + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 7 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoJulio = GastoJulio + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 8 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoAgosto = GastoAgosto + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 9 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoSeptiembre = GastoSeptiembre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 10 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {   
                    GastoOctubre = GastoOctubre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 11 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoNoviembre = GastoNoviembre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 12 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] < 0)
                {
                    GastoDiciembre = GastoDiciembre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 1 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoEnero = IngresoEnero + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 2 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoFebrero = IngresoFebrero + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 3 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoMarzo = IngresoMarzo + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 4 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoAbril = IngresoAbril + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 5 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoMayo = IngresoMayo + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 6 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoJunio = IngresoJunio + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 7 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoJulio = IngresoJulio + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 8 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoAgosto = IngresoAgosto + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 9 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoSeptiembre = IngresoSeptiembre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 10 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoOctubre = IngresoOctubre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 11 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoNoviembre = IngresoNoviembre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
                else if (Balance.InstanciaBalance.ObtenerMeses()[i] == 12 && Balance.InstanciaBalance.ObtenerFlujoReportes()[i] > 0)
                {
                    IngresoDiciembre = IngresoDiciembre + Balance.InstanciaBalance.ObtenerFlujoReportes()[i];
                }
            }
            GastosMes.Add("Enero: ₡" + GastoEnero);
            GastosMes.Add("Febrero: ₡" + GastoFebrero);
            GastosMes.Add("Marzo: ₡" + GastoMarzo);
            GastosMes.Add("Abril: ₡" + GastoAbril);
            GastosMes.Add("Mayo: ₡" + GastoMayo);
            GastosMes.Add("Junio: ₡" + GastoJunio);
            GastosMes.Add("Julio: ₡" + GastoJulio);
            GastosMes.Add("Agosto: ₡" + GastoAgosto);
            GastosMes.Add("Septiembre: ₡" + GastoSeptiembre);
            GastosMes.Add("Octubre: ₡" + GastoOctubre);
            GastosMes.Add("Noviembre: ₡" + GastoNoviembre);
            GastosMes.Add("Diciembre: ₡" + GastoDiciembre);
            IngresosMes.Add("Enero: ₡" + IngresoEnero);
            IngresosMes.Add("Febrero: ₡" + IngresoFebrero);
            IngresosMes.Add("Marzo: ₡" + IngresoMarzo);
            IngresosMes.Add("Abril: ₡" + IngresoAbril);
            IngresosMes.Add("Mayo: ₡" + IngresoMayo);
            IngresosMes.Add("Junio: ₡" + IngresoJunio);
            IngresosMes.Add("Julio: ₡" + IngresoJulio);
            IngresosMes.Add("Agosto: ₡" + IngresoAgosto);
            IngresosMes.Add("Septiembre: ₡" + IngresoSeptiembre);
            IngresosMes.Add("Octubre: ₡" + IngresoOctubre);
            IngresosMes.Add("Noviembre: ₡" + IngresoNoviembre);
            IngresosMes.Add("Diciembre: ₡" + IngresoDiciembre);
        }
        #endregion
        private void VentanaCargada(object sender, EventArgs e)
        {
            if(ComboBoxAno.Items.Count == 0)
            {
                for (int year = DateTime.Now.Year - 10; year <= DateTime.Now.Year + 10; year++)
                {
                    ComboBoxAno.Items.Add(year);
                }
            }
            Balance.InstanciaBalance.BuscarAno(int.Parse((ComboBoxAno.SelectedValue).ToString()));
            FlujoCategoria();
            FlujoCuenta();
            FlujoMes();
            LstBoxGastosCategorias.ItemsSource = new List<string>();
            LstBoxIngresosCategorias.ItemsSource = new List<string>();
            LstBoxGastosCuentas.ItemsSource = new List<string>();
            LstBoxIngresosCuentas.ItemsSource = new List<string>();
            LstBoxGastosMes.ItemsSource = new List<string>();
            LstBoxIngresosMes.ItemsSource = new List<string>();
            LstBoxGastosCategorias.ItemsSource = GastosCategoria;
            LstBoxIngresosCategorias.ItemsSource = IngresosCategoria;
            LstBoxGastosCuentas.ItemsSource = GastosCuenta;
            LstBoxIngresosCuentas.ItemsSource = IngresosCuenta;
            LstBoxGastosMes.ItemsSource = GastosMes;
            LstBoxIngresosMes.ItemsSource = IngresosMes;
        }
    }
}

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
    /// Interaction logic for WindowReportes.xaml
    /// </summary>
    public partial class WindowReportes : Window
    {
        public WindowReportes()
        {
            InitializeComponent();
        }
        private static WindowReportes Instancia;
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
            System.Windows.Application.Current.Shutdown();
        }
    }
}

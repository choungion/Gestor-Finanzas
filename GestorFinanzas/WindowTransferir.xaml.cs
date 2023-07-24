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
    /// Interaction logic for WindowTransferir.xaml
    /// </summary>
    public partial class WindowTransferir : Window
    {
        public WindowTransferir()
        {
            InitializeComponent();
        }
        private static WindowTransferir Instancia;
        public static WindowTransferir InstanciaTransferir
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowTransferir();
                }
                return Instancia;
            }
        }

        private void ButtonTransferir_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow.InstanciaMain.Show();
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow.InstanciaMain.Show();
        }
    }
}

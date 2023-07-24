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
    /// Interaction logic for WindowHistorial.xaml
    /// </summary>
    public partial class WindowHistorial : Window
    {
        private static WindowHistorial Instancia;
        public static WindowHistorial InstanciaHistorial
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowHistorial();
                }
                return Instancia;
            }
        }
    }
    
}

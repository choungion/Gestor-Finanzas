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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DATOS_PERSONA ADMINISTRADOR = new DATOS_PERSONA("ADMIN","");
            REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[0] = ADMINISTRADOR;
        }


        private void INICIAR_sesion(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < REGISTROS_STATICOS.ARREGLO_DE_USUARIOS.Length; i++)
            {
                if (REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] != null)
                {
                    if (this.txt_USERNAME.Text == REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i].User1 && this.txt_PASSWORD.Password == REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i].Password)
                    {
                        MessageBox.Show("the password has been passed ");
                        PANTALLA_PRINCIPAL INICIO = new PANTALLA_PRINCIPAL();
                        INICIO.Show();
                        break;
                    }
                }
            }
            
        }

        private void REGISTRO_usuario(object sender, RoutedEventArgs e)
        {
            
            VENTANA_REGISTRO_USUARIOS ventana_REGISTROS = new VENTANA_REGISTRO_USUARIOS();
            ventana_REGISTROS.Show();

        }
    }
}


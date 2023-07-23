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
    public partial class WindowInicioSesion : Window
    {
        public WindowInicioSesion()
        {
            InitializeComponent();
            DATOS_PERSONA ADMINISTRADOR = new DATOS_PERSONA("ADMIN", "");
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
                        MainWindow INICIO = new MainWindow();
                        INICIO.Show();
                        Hide();
                        break;
                    }
                    else if (this.txt_USERNAME.Text == "admin" && this.txt_PASSWORD.Password == "admin")
                    {
                        MainWindow INICIO = new MainWindow();
                        INICIO.Show();
                        Hide();
                        break;
                    }
                }
                else {
                    MessageBox.Show("NO HAS INICIADO SESSION");
                    break;
                }
            }

        }

        private void REGISTRO_usuario(object sender, RoutedEventArgs e)
        {

            WindowRegistroUsuario ventana_REGISTROS = new WindowRegistroUsuario();
            ventana_REGISTROS.Show();
        }
    }
}


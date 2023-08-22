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
        private static WindowInicioSesion Instancia;
        public static WindowInicioSesion InstanciaInicioSesion
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new WindowInicioSesion();
                }
                return Instancia;
            }
        }

        private void INICIAR_sesion(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < REGISTROS_STATICOS.ARREGLO_DE_USUARIOS.Length; i++)
            {
                if (REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] != null)
                {
                    if (this.txt_USERNAME.Text == REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i].User1 && this.txt_PASSWORD.Password == REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i].Password)
                    {
                        Balance.InstanciaBalance.IngresarUsuarioActivo(this.txt_USERNAME.Text);
                        MainWindow.InstanciaMain.Show();
                        Hide();
                        break;
                    }
                    else if (this.txt_USERNAME.Text == "admin" && this.txt_PASSWORD.Password == "admin")
                    {
                        Balance.InstanciaBalance.IngresarUsuarioActivo(this.txt_USERNAME.Text);
                        MainWindow.InstanciaMain.Show();
                        WindowSalir.InstanciaSalir.Hide();
                        Hide();
                        break;
                    }
                }
            }

        }

        private void REGISTRO_usuario(object sender, RoutedEventArgs e)
        {

            WindowRegistroUsuario ventana_REGISTROS = new WindowRegistroUsuario();
            Hide();
            ventana_REGISTROS.Show();
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_Salir(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        
        
    }
}


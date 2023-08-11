
using System.Windows;

namespace GestorFinanzas
{
    public partial class WindowInicioSesion : Window
    {
        public WindowInicioSesion()
        {
            InitializeComponent();
            Balance balanceADMIN = new Balance();
            DATOS_PERSONA ADMINISTRADOR = new DATOS_PERSONA("administrador","0000","0000","","ADMIN",balanceADMIN);
            REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[0] = ADMINISTRADOR;
        }


        private void INICIAR_sesion(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < REGISTROS_STATICOS.ARREGLO_DE_USUARIOS.Length; i++)
            {
                if (REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] != null)
                {
                    if (this.txt_USERNAME.Text == REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i].get_USUARIO() && this.txt_PASSWORD.Password == REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i].get_CONTRASENA())
                    {
                       
                        MessageBox.Show("the password has been passed ");
                        MainWindow.indicePERSONA_APP = i;

                        

                        //por cada inicio de sesion se crea una nueva instancia 
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
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

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}


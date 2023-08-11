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
    public partial class WindowRegistroUsuario : Window
    {
        public WindowRegistroUsuario()
        {
            InitializeComponent();
        }

        private void Registrando_persona(object sender, RoutedEventArgs e)
        {
            Balance nuevobalance = new Balance();
            DATOS_PERSONA persona_nueva = new DATOS_PERSONA(this.nombre_persona.Text, this.numero_telefono.Text,
                this.cedula_persona.Text, this.nueva_password.Text, this.nuevo_nombre_usuario.Text,nuevobalance);

            for (int i = 0; i < REGISTROS_STATICOS.ARREGLO_DE_USUARIOS.Length; i++)
            {
                if (REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] == null)
                {
                    REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] = persona_nueva;
                    MessageBox.Show("REGISTRADO CON EXITO", "BIENVENIDO", MessageBoxButton.OK, MessageBoxImage.Information);
                    Hide();
                    break;
                }

            }
        }

        private void CerrarVentana(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}

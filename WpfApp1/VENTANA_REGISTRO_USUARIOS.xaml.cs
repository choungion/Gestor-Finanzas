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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para VENTANA_REGISTRO_USUARIOS.xaml
    /// </summary>
    public partial class VENTANA_REGISTRO_USUARIOS : Window
    {
        public VENTANA_REGISTRO_USUARIOS()
        {
            InitializeComponent();
        }

        private void Registrando_persona(object sender, RoutedEventArgs e)
        {
            DATOS_PERSONA persona_nueva = new DATOS_PERSONA(this.nombre_persona.Text,this.numero_telefono.Text,
                this.cedula_persona.Text ,this.nueva_password.Text,this.nuevo_nombre_usuario.Text);

            for (int i = 0;i < REGISTROS_STATICOS.ARREGLO_DE_USUARIOS.Length;i++) {
                if (REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] == null) {
                    REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] = persona_nueva;
                    MessageBox.Show("REGISTRADO CON EXITO", "BIENVENIDO", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                }
            
            }
        }
    }
}

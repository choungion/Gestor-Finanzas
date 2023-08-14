using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            WindowStyle = WindowStyle.None;
        }
        private bool FlagNombre = false;
        private bool FlagNumero = false;
        private bool FlagCedula = false;
        private bool FlagUsuario = false;
        private bool FlagPassword = false;

        private void Nombre_Persona_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string pattern = "^[a-zA-Z]*(?: [a-zA-Z]*){0,2}$";
            Regex regex = new Regex(pattern);

            string newText = nombre_persona.Text + e.Text;
            if (!regex.IsMatch(newText))
            {
                e.Handled = true;
            }
        }
        private void Numero_Telefono_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
        private void Numero_Telefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string pattern = "^[0-9]{0,8}$";
            Regex regex = new Regex(pattern);

            string newText = numero_telefono.Text + e.Text;
            if (!regex.IsMatch(newText))
            {
                e.Handled = true;
            }
        }
        private void Cedula_Persona_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
        private void Cedula_Persona_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pattern = "^[0-9]*$";
            Regex regex = new Regex(pattern);

            TextBox textBox = (TextBox)sender;
            if (!regex.IsMatch(textBox.Text) || textBox.Text.Length > 9)
            {
                int caretIndex = textBox.CaretIndex;
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.CaretIndex = caretIndex - 1;
            }
        }
        private void Nombre_Usuario_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
        private void Nueva_Password_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
        private void Registrando_persona(object sender, RoutedEventArgs e)
        {
            DATOS_PERSONA persona_nueva = new DATOS_PERSONA(this.nombre_persona.Text, this.numero_telefono.Text,
                this.cedula_persona.Text, this.nueva_password.Text, this.nuevo_nombre_usuario.Text);

            string hexLightRed = "#FF0000";
            BrushConverter converter = new BrushConverter();
            Brush RojoClaro = (Brush)converter.ConvertFromString(hexLightRed);
            if (string.IsNullOrEmpty(nombre_persona.Text))
            {
                nombre_persona.Background = RojoClaro;
            }
            else
            {
                nombre_persona.Background = null;
                FlagNombre = true;
            }
            if (string.IsNullOrEmpty(numero_telefono.Text))
            {
                numero_telefono.Background = RojoClaro;
            }
            else
            {
                numero_telefono.Background = null;
                FlagNumero = true;
            }
            if (string.IsNullOrEmpty(cedula_persona.Text))
            {
                cedula_persona.Background = RojoClaro;
            }
            else
            {
                cedula_persona.Background = null;
                FlagCedula = true;
            }
            if (string.IsNullOrEmpty(nuevo_nombre_usuario.Text))
            {
                nuevo_nombre_usuario.Background = RojoClaro;
            }
            else
            {
               nuevo_nombre_usuario.Background = null;
                FlagUsuario = true;
            }
            if (string.IsNullOrEmpty(nueva_password.Text))
            {
                nueva_password.Background = RojoClaro;
            }
            else
            {
                nueva_password.Background = null;
                FlagPassword = true;
            }
            if (FlagNombre == true && FlagNumero == true && FlagCedula == true && FlagUsuario == true && FlagPassword == true)
            {
                for (int i = 0; i < REGISTROS_STATICOS.ARREGLO_DE_USUARIOS.Length; i++)
                {
                    if (REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] == null)
                    {
                        REGISTROS_STATICOS.ARREGLO_DE_USUARIOS[i] = persona_nueva;
                        MessageBox.Show("REGISTRADO CON EXITO", "BIENVENIDO", MessageBoxButton.OK, MessageBoxImage.Information);
                        Hide();
                        WindowInicioSesion.InstanciaInicioSesion.Show();
                        break;
                    }

                }
            }
            else
            {
                //MessageBox.Show("Llene todos los campos");
            }
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
            WindowInicioSesion.InstanciaInicioSesion.Show();
        }
    }
}

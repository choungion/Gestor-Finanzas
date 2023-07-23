﻿using System;
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
    /// Interaction logic for WindowGastos.xaml
    /// </summary>
    public partial class WindowGastos : Window
    {
        public WindowGastos()
        {
            InitializeComponent();
        }
        private MainWindow main;

        public WindowGastos(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private void ComboBoxCuentas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString() == "Banco")
            {
                Uri imagePath = new Uri("/bank.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen;
            }
            else if (((ComboBoxItem)ComboBoxCuentas.SelectedItem).Content.ToString() == "Efectivo")
            {
                Uri imagePath = new Uri("/Wallet.png", UriKind.RelativeOrAbsolute);
                BitmapImage imagen = new BitmapImage(imagePath);
                ImageIcono.Source = imagen;
            }
        }
        private void ButtonFechaGasto_Click(object sender, RoutedEventArgs e)
        {
            Calendario.Visibility = Visibility.Visible;
        }
        private void Calendario_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar calendario = (Calendar)sender;
            if (calendario.SelectedDate.HasValue)
            {
                var selectedDate = calendario.SelectedDate.Value;
                MessageBox.Show($"Selected Date: {selectedDate.ToShortDateString()}");
                Calendario.Visibility = Visibility.Hidden;
            }
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            main.Show();
        }

        private void ButtonGuardar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            main.Show();
        }
    }
}

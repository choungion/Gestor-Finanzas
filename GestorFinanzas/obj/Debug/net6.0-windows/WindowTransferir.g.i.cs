﻿#pragma checksum "..\..\..\WindowTransferir.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7937880719571F3B9ADAC2EE7DD8A1100F1B79B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using GestorFinanzas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GestorFinanzas {
    
    
    /// <summary>
    /// WindowTransferir
    /// </summary>
    public partial class WindowTransferir : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCuentaOrigen;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCuentaDestino;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonTransferir;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancelar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxCantidad;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFechaingreso;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar Calendario;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\WindowTransferir.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelFecha;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestorFinanzas;component/windowtransferir.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowTransferir.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\WindowTransferir.xaml"
            ((GestorFinanzas.WindowTransferir)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.CerrarVentana);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBoxCuentaOrigen = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\..\WindowTransferir.xaml"
            this.ComboBoxCuentaOrigen.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxCuentaOrigen_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboBoxCuentaDestino = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ButtonTransferir = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\WindowTransferir.xaml"
            this.ButtonTransferir.Click += new System.Windows.RoutedEventHandler(this.ButtonTransferir_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\WindowTransferir.xaml"
            this.ButtonCancelar.Click += new System.Windows.RoutedEventHandler(this.ButtonCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TxtBoxCantidad = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\WindowTransferir.xaml"
            this.TxtBoxCantidad.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtBoxCantidad_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonFechaingreso = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\WindowTransferir.xaml"
            this.ButtonFechaingreso.Click += new System.Windows.RoutedEventHandler(this.ButtonFechaIngreso_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Calendario = ((System.Windows.Controls.Calendar)(target));
            
            #line 30 "..\..\..\WindowTransferir.xaml"
            this.Calendario.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Calendario_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LabelFecha = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\WindowGastos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC758DA62193F020E95FCD49F84953D661B94A41"
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
    /// WindowGastos
    /// </summary>
    public partial class WindowGastos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxCantidad;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonGuardar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancelar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCuentas;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageIcono;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar Calendario;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFechaGasto;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelFecha;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\WindowGastos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCategorias;
        
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
            System.Uri resourceLocater = new System.Uri("/GestorFinanzas;component/windowgastos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowGastos.xaml"
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
            this.TxtBoxCantidad = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\WindowGastos.xaml"
            this.TxtBoxCantidad.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtBoxCantidad_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\WindowGastos.xaml"
            this.ButtonGuardar.Click += new System.Windows.RoutedEventHandler(this.ButtonGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\WindowGastos.xaml"
            this.ButtonCancelar.Click += new System.Windows.RoutedEventHandler(this.ButtonCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboBoxCuentas = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\WindowGastos.xaml"
            this.ComboBoxCuentas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxCuentas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ImageIcono = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.Calendario = ((System.Windows.Controls.Calendar)(target));
            
            #line 22 "..\..\..\WindowGastos.xaml"
            this.Calendario.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Calendario_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonFechaGasto = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\WindowGastos.xaml"
            this.ButtonFechaGasto.Click += new System.Windows.RoutedEventHandler(this.ButtonFechaGasto_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LabelFecha = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.ComboBoxCategorias = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


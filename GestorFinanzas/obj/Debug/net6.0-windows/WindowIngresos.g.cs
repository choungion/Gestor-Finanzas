﻿#pragma checksum "..\..\..\WindowIngresos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "020E334DB4C6D6A598AB91FD72DA70086584A085"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    /// WindowIngresos
    /// </summary>
    public partial class WindowIngresos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\WindowIngresos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBoxCantidad;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WindowIngresos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonGuardar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WindowIngresos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancelar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\WindowIngresos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuPrincipal;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WindowIngresos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxCuentas;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\WindowIngresos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageIcono;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestorFinanzas;component/windowingresos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowIngresos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TxtBoxCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ButtonGuardar = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.ButtonCancelar = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.MenuPrincipal = ((System.Windows.Controls.Menu)(target));
            return;
            case 5:
            this.ComboBoxCuentas = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\WindowIngresos.xaml"
            this.ComboBoxCuentas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxCuentas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImageIcono = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

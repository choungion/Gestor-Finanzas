﻿#pragma checksum "..\..\..\WindowRegistroUsuario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4F8942379D23F0DC5DBCA8CEC2758F420BD4CB80"
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
    /// WindowRegistroUsuario
    /// </summary>
    public partial class WindowRegistroUsuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\WindowRegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombre_persona;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WindowRegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numero_telefono;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\WindowRegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cedula_persona;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\WindowRegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nuevo_nombre_usuario;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\WindowRegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nueva_password;
        
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
            System.Uri resourceLocater = new System.Uri("/GestorFinanzas;component/windowregistrousuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowRegistroUsuario.xaml"
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
            
            #line 8 "..\..\..\WindowRegistroUsuario.xaml"
            ((GestorFinanzas.WindowRegistroUsuario)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.CerrarVentana);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nombre_persona = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.numero_telefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cedula_persona = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.nuevo_nombre_usuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.nueva_password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 29 "..\..\..\WindowRegistroUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Registrando_persona);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


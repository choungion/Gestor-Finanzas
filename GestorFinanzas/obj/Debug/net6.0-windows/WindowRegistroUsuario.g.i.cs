﻿#pragma checksum "..\..\..\WindowRegistroUsuario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D53134398B751316FEAEFAD54640F1A51D734D2F"
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
        
        
        #line 28 "..\..\..\WindowRegistroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/GestorFinanzas;component/windowregistrousuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowRegistroUsuario.xaml"
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
            this.nombre_persona = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\WindowRegistroUsuario.xaml"
            this.nombre_persona.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Nombre_Persona_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\WindowRegistroUsuario.xaml"
            this.nombre_persona.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtbox_Mouse_Enter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.numero_telefono = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\WindowRegistroUsuario.xaml"
            this.numero_telefono.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Numero_Telefono_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\WindowRegistroUsuario.xaml"
            this.numero_telefono.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Numero_Telefono_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\WindowRegistroUsuario.xaml"
            this.numero_telefono.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtbox_Mouse_Enter);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cedula_persona = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\WindowRegistroUsuario.xaml"
            this.cedula_persona.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Cedula_Persona_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\WindowRegistroUsuario.xaml"
            this.cedula_persona.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Cedula_Persona_TextChanged);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\WindowRegistroUsuario.xaml"
            this.cedula_persona.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtbox_Mouse_Enter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.nuevo_nombre_usuario = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\WindowRegistroUsuario.xaml"
            this.nuevo_nombre_usuario.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Nombre_Usuario_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\WindowRegistroUsuario.xaml"
            this.nuevo_nombre_usuario.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtbox_Mouse_Enter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.nueva_password = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\WindowRegistroUsuario.xaml"
            this.nueva_password.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Nueva_Password_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\WindowRegistroUsuario.xaml"
            this.nueva_password.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtbox_Mouse_Enter);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 27 "..\..\..\WindowRegistroUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Registrando_persona);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\WindowRegistroUsuario.xaml"
            this.ButtonCancelar.Click += new System.Windows.RoutedEventHandler(this.ButtonCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


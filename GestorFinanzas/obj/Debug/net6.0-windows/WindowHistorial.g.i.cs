﻿#pragma checksum "..\..\..\WindowHistorial.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B1B3F0777CC8AE5851191857695F28D918A34588"
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
    /// WindowHistorial
    /// </summary>
    public partial class WindowHistorial : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\WindowHistorial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRegresar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WindowHistorial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelTotal;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\WindowHistorial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxCategoria;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WindowHistorial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxFecha;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\WindowHistorial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxCantidades;
        
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
            System.Uri resourceLocater = new System.Uri("/GestorFinanzas;component/windowhistorial.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowHistorial.xaml"
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
            
            #line 8 "..\..\..\WindowHistorial.xaml"
            ((GestorFinanzas.WindowHistorial)(target)).Activated += new System.EventHandler(this.VentanaCargada);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\WindowHistorial.xaml"
            this.ButtonRegresar.Click += new System.Windows.RoutedEventHandler(this.ButtonRegresar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LabelTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ListBoxCategoria = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.ListBoxFecha = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.ListBoxCantidades = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


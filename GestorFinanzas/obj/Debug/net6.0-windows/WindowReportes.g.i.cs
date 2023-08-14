﻿#pragma checksum "..\..\..\WindowReportes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BBF74B2E660D2918FBF0D82EADF9EDDE20075613"
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
using LiveCharts.Wpf;
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
    /// WindowReportes
    /// </summary>
    public partial class WindowReportes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChartGastoCategorias;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChartGastoCuentas;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChartGastoMes;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuPrincipal;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemTransacciones;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemReportes;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChartIngresoCategorias;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChartIngresoCuentas;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChartIngresoMes;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\WindowReportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxAno;
        
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
            System.Uri resourceLocater = new System.Uri("/GestorFinanzas;component/windowreportes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowReportes.xaml"
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
            
            #line 10 "..\..\..\WindowReportes.xaml"
            ((GestorFinanzas.WindowReportes)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.CerrarVentana);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PieChartGastoCategorias = ((LiveCharts.Wpf.PieChart)(target));
            return;
            case 3:
            this.PieChartGastoCuentas = ((LiveCharts.Wpf.PieChart)(target));
            return;
            case 4:
            this.PieChartGastoMes = ((LiveCharts.Wpf.PieChart)(target));
            return;
            case 5:
            this.MenuPrincipal = ((System.Windows.Controls.Menu)(target));
            return;
            case 6:
            this.MenuItemTransacciones = ((System.Windows.Controls.MenuItem)(target));
            
            #line 51 "..\..\..\WindowReportes.xaml"
            this.MenuItemTransacciones.Click += new System.Windows.RoutedEventHandler(this.MenuItemTransacciones_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MenuItemReportes = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.PieChartIngresoCategorias = ((LiveCharts.Wpf.PieChart)(target));
            return;
            case 9:
            this.PieChartIngresoCuentas = ((LiveCharts.Wpf.PieChart)(target));
            return;
            case 10:
            this.PieChartIngresoMes = ((LiveCharts.Wpf.PieChart)(target));
            return;
            case 11:
            this.ComboBoxAno = ((System.Windows.Controls.ComboBox)(target));
            
            #line 91 "..\..\..\WindowReportes.xaml"
            this.ComboBoxAno.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxAno_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


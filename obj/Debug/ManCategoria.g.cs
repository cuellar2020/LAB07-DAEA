﻿#pragma checksum "..\..\ManCategoria.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "10399869FA8A646251AF7E471A3859886A08BFB47111117637974E9E588D60CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Semana05;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Semana05 {
    
    
    /// <summary>
    /// ManCategoria
    /// </summary>
    public partial class ManCategoria : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ManCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblID;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ManCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ManCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ManCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGrabar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ManCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ManCategoria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Semana05;component/mancategoria.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManCategoria.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblID = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnGrabar = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\ManCategoria.xaml"
            this.btnGrabar.Click += new System.Windows.RoutedEventHandler(this.BtnGrabar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ManCategoria.xaml"
            this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.BtnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\ManCategoria.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.BtnEliminar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\Presentation\RegisterWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A593CB5FA1B9C06B68EAE01E93860CA343022EAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using OtherCryptedLogin.Presentation;
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


namespace OtherCryptedLogin.Presentation {
    
    
    /// <summary>
    /// RegisterWindow
    /// </summary>
    public partial class RegisterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\Presentation\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRegisterEmail;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Presentation\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textEmail;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Presentation\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtRegisterPassword;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Presentation\RegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textPassword;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OtherCryptedLogin;V1.0.0.0;component/presentation/registerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Presentation\RegisterWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtRegisterEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\..\Presentation\RegisterWindow.xaml"
            this.txtRegisterEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEmail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textEmail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtRegisterPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 51 "..\..\..\..\Presentation\RegisterWindow.xaml"
            this.txtRegisterPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 55 "..\..\..\..\Presentation\RegisterWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegisterButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 56 "..\..\..\..\Presentation\RegisterWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


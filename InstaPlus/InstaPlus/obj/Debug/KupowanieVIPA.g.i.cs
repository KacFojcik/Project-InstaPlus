﻿#pragma checksum "..\..\KupowanieVIPA.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C2A366B99DBCD5C6E064690F3A2D13522BACA18D4213333CA540A9E4B3187B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using PBD_działające__y_;
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


namespace PBD_działające__y_ {
    
    
    /// <summary>
    /// KupowanieVIPA
    /// </summary>
    public partial class KupowanieVIPA : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\KupowanieVIPA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVIPnaROK;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\KupowanieVIPA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVIPnaPółRoku;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\KupowanieVIPA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVIPnaMiesiac;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\KupowanieVIPA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnulujZakup;
        
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
            System.Uri resourceLocater = new System.Uri("/PBD działające (y);component/kupowanievipa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KupowanieVIPA.xaml"
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
            this.btnVIPnaROK = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\KupowanieVIPA.xaml"
            this.btnVIPnaROK.Click += new System.Windows.RoutedEventHandler(this.btnVIPnaMiesiac_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnVIPnaPółRoku = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\KupowanieVIPA.xaml"
            this.btnVIPnaPółRoku.Click += new System.Windows.RoutedEventHandler(this.btnVIPnaPółRoku_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnVIPnaMiesiac = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\KupowanieVIPA.xaml"
            this.btnVIPnaMiesiac.Click += new System.Windows.RoutedEventHandler(this.btnVIPnaMiesiac_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAnulujZakup = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\KupowanieVIPA.xaml"
            this.btnAnulujZakup.Click += new System.Windows.RoutedEventHandler(this.btnAnulujZakup_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\SahaEkle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9A4D77C5D4560B93EFD72A5C1DE4E900C8E573AD6B3D7AD8CF4F296726B8D6FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using HaliSaha;
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


namespace HaliSaha {
    
    
    /// <summary>
    /// SahaEkle
    /// </summary>
    public partial class SahaEkle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\SahaEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgsaha;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\SahaEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsahaad;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SahaEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsahafiyat;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SahaEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsahakapasite;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SahaEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsahakonum;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\SahaEkle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsahaid;
        
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
            System.Uri resourceLocater = new System.Uri("/HaliSaha;component/sahaekle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SahaEkle.xaml"
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
            this.dgsaha = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\SahaEkle.xaml"
            this.dgsaha.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgsaha_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtsahaad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtsahafiyat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtsahakapasite = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtsahakonum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 26 "..\..\SahaEkle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Ekle);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 27 "..\..\SahaEkle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Sil);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtsahaid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 35 "..\..\SahaEkle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


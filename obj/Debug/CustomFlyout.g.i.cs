﻿#pragma checksum "..\..\CustomFlyout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "28EB7CEB1913237A1E4E3A45AB9B2A9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace WpfApplication5 {
    
    
    /// <summary>
    /// CustomFlyout
    /// </summary>
    public partial class CustomFlyout : MahApps.Metro.Controls.Flyout, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApplication5.CustomFlyout customFlyout;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_search;
        
        #line default
        #line hidden
        
        
        #line 371 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown numeric_ini2;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown numeric_end2;
        
        #line default
        #line hidden
        
        
        #line 373 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label11;
        
        #line default
        #line hidden
        
        
        #line 374 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label22;
        
        #line default
        #line hidden
        
        
        #line 375 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label11_Copy;
        
        #line default
        #line hidden
        
        
        #line 378 "..\..\CustomFlyout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Extrator de E-mails Torpedos Brasil;component/customflyout.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomFlyout.xaml"
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
            this.customFlyout = ((WpfApplication5.CustomFlyout)(target));
            return;
            case 2:
            this.textbox_search = ((System.Windows.Controls.TextBox)(target));
            
            #line 360 "..\..\CustomFlyout.xaml"
            this.textbox_search.KeyDown += new System.Windows.Input.KeyEventHandler(this.textbox_search_KeyDown);
            
            #line default
            #line hidden
            
            #line 360 "..\..\CustomFlyout.xaml"
            this.textbox_search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textbox_search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.numeric_ini2 = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 4:
            this.numeric_end2 = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 5:
            this.label11 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.label22 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.label11_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\..\..\Controls\SocialMediaBrowser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8BB30329D7AF05A010FD390761EDC0CC18A0FC81"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ABMedia83Studio.Controls;
using Albert.Win32.Controls;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ABMedia83Studio.Controls {
    
    
    /// <summary>
    /// SocialMediaBrowser
    /// </summary>
    public partial class SocialMediaBrowser : ABMedia83Studio.Controls.StudioControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Controls\SocialMediaBrowser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSites;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Controls\SocialMediaBrowser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Web.WebView2.Wpf.WebView2 webBrowser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ABMedia83StudioMT;component/controls/socialmediabrowser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\SocialMediaBrowser.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cmbSites = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            
            #line 19 "..\..\..\..\Controls\SocialMediaBrowser.xaml"
            ((Albert.Win32.Controls.PushButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Web_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\..\..\Controls\SocialMediaBrowser.xaml"
            ((Albert.Win32.Controls.PushButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Web_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 21 "..\..\..\..\Controls\SocialMediaBrowser.xaml"
            ((Albert.Win32.Controls.PushButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Web_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.webBrowser = ((Microsoft.Web.WebView2.Wpf.WebView2)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

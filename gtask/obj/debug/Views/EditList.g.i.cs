﻿#pragma checksum "C:\Users\mloflin\Documents\Visual Studio 2015\Projects\gTask\gTask\Views\EditList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "91778DA3330C46636E435DCAFB1C8678"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Advertising.Mobile.UI;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace gTask.Views {
    
    
    public partial class EditList : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txtTitle;
        
        internal System.Windows.Controls.TextBlock txtPageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtbxTitle;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl AdControl;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/gTask;component/Views/EditList.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txtTitle")));
            this.txtPageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txtPageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtbxTitle = ((System.Windows.Controls.TextBox)(this.FindName("txtbxTitle")));
            this.AdControl = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("AdControl")));
        }
    }
}


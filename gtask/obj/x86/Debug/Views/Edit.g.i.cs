﻿#pragma checksum "C:\Users\mloflin\Documents\Visual Studio 2012\Projects\gTask\gTask\gTask\Views\Edit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1F0BFAB015BF1ACDD589704E9FE4CA5A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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
    
    
    public partial class Edit : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txtTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ScrollViewer scrollViewer1;
        
        internal System.Windows.Controls.TextBox txtbxTitle;
        
        internal System.Windows.Controls.ScrollViewer scrollViewer2;
        
        internal System.Windows.Controls.TextBox txtNotes;
        
        internal Microsoft.Phone.Controls.DatePicker txtDueDate;
        
        internal System.Windows.Controls.CheckBox chkNoDueDate;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/gTask;component/Views/Edit.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txtTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.scrollViewer1 = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewer1")));
            this.txtbxTitle = ((System.Windows.Controls.TextBox)(this.FindName("txtbxTitle")));
            this.scrollViewer2 = ((System.Windows.Controls.ScrollViewer)(this.FindName("scrollViewer2")));
            this.txtNotes = ((System.Windows.Controls.TextBox)(this.FindName("txtNotes")));
            this.txtDueDate = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("txtDueDate")));
            this.chkNoDueDate = ((System.Windows.Controls.CheckBox)(this.FindName("chkNoDueDate")));
            this.AdControl = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("AdControl")));
        }
    }
}


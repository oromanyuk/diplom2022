﻿#pragma checksum "..\..\..\AddEditPageTransportAdm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7B9B93FEC1A8A6836F7ED1E6921E1CB96DA993FC904ABB205BBC0F64CC3C8F0C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using logistic;


namespace logistic {
    
    
    /// <summary>
    /// AddEditPageTransportAdm
    /// </summary>
    public partial class AddEditPageTransportAdm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\AddEditPageTransportAdm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxCargoSize;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AddEditPageTransportAdm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxLenghtPath;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AddEditPageTransportAdm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxPrice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AddEditPageTransportAdm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxCargoType;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AddEditPageTransportAdm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Save_Transport_Adm;
        
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
            System.Uri resourceLocater = new System.Uri("/logistic;component/addeditpagetransportadm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddEditPageTransportAdm.xaml"
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
            this.BoxCargoSize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BoxLenghtPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BoxPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BoxCargoType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Btn_Save_Transport_Adm = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\AddEditPageTransportAdm.xaml"
            this.Btn_Save_Transport_Adm.Click += new System.Windows.RoutedEventHandler(this.Btn_Save_Transport_Adm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


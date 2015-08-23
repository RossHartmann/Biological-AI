﻿#pragma checksum "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E17FB69AEA5BE97AD07432157E150CE3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneticFaradayApplication.Views.Views.GeneticCodes;
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


namespace GeneticFaradayApplication.Views.Views.GeneticCodes {
    
    
    /// <summary>
    /// GeneticCodeEditorView
    /// </summary>
    public partial class GeneticCodeEditorView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GeneticFaradayApplication.Views.Views.GeneticCodes.GeneticCodeBasicInfoView basic_genetic_code_info;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem nucleotides_tab_item;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem codons_tab_item;
        
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
            System.Uri resourceLocater = new System.Uri("/GeneticFaradayApplication;component/views/views/geneticcodes/geneticcodeeditorvi" +
                    "ew.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.basic_genetic_code_info = ((GeneticFaradayApplication.Views.Views.GeneticCodes.GeneticCodeBasicInfoView)(target));
            return;
            case 2:
            this.nucleotides_tab_item = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.codons_tab_item = ((System.Windows.Controls.TabItem)(target));
            return;
            case 4:
            
            #line 31 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewGeneticCode_MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenGeneticCode_MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 34 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveGeneticCode_MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 36 "..\..\..\..\..\Views\Views\GeneticCodes\GeneticCodeEditorView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitGeneticCode_MenuItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9178E80DA0ECE0AA96F87EF7A366C5C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace GeneticFaradayApplication.Views.Views.GeneticCodes.Functions {
    
    
    /// <summary>
    /// FunctionsView
    /// </summary>
    public partial class FunctionsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox available_functions_list_box;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox selected_functions_list_box;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button move_to_selected_functions_button;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button move_to_available_functions_button;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button move_all_to_selected_functions_button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button move_all_to_available_functions_button;
        
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
            System.Uri resourceLocater = new System.Uri("/GeneticFaradayApplication;component/views/views/geneticcodes/functions/functions" +
                    "view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
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
            this.available_functions_list_box = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.selected_functions_list_box = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.move_to_selected_functions_button = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
            this.move_to_selected_functions_button.Click += new System.Windows.RoutedEventHandler(this.move_to_selected_functions_button_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.move_to_available_functions_button = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
            this.move_to_available_functions_button.Click += new System.Windows.RoutedEventHandler(this.move_to_available_functions_button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.move_all_to_selected_functions_button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
            this.move_all_to_selected_functions_button.Click += new System.Windows.RoutedEventHandler(this.move_all_to_selected_functions_button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.move_all_to_available_functions_button = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
            this.move_all_to_available_functions_button.Click += new System.Windows.RoutedEventHandler(this.move_all_to_available_functions_button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 12 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.available_functions_list_box_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 4:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 24 "..\..\..\..\..\..\Views\Views\GeneticCodes\Functions\FunctionsView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.selected_functions_list_box_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}


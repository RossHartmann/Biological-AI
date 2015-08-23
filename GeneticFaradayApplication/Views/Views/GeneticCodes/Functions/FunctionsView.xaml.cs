using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Utilities;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes.Functions
{
    /// <summary>
    /// Interaction logic for FunctionsView.xaml
    /// </summary>
    public partial class FunctionsView : UserControl, IFunctionsView
    {

        public FunctionsView()
        {
            InitializeComponent();
        }

        public event EventHandler MoveAllToAvailableFunctionsRequested;
        protected virtual void OnMoveAllToAvailableFunctionsRequested(EventArgs e)
        {
            if (this.MoveAllToAvailableFunctionsRequested != null)
                this.MoveAllToAvailableFunctionsRequested(this, e);
        }

        public event EventHandler MoveAllToSelectedFunctionsRequested;
        protected virtual void OnMoveAllToSelectedFunctionsRequested(EventArgs e)
        {
            if (this.MoveAllToSelectedFunctionsRequested != null)
                this.MoveAllToSelectedFunctionsRequested(this, e);
        }

        public event EventHandler<EventArgsWithModel<IFunctionBaseIdentifier>> MoveToAvailableFunctionsRequested;
        protected virtual void OnMoveToAvailableFunctionsRequested(EventArgsWithModel<IFunctionBaseIdentifier> e)
        {
            if (this.MoveToAvailableFunctionsRequested != null)
                this.MoveToAvailableFunctionsRequested(this, e);
        }

        public event EventHandler<EventArgsWithModel<IFunctionBaseIdentifier>> MoveToSelectedFunctionsRequested;
        protected virtual void OnMoveToSelectedFunctionsRequested(EventArgsWithModel<IFunctionBaseIdentifier> e)
        {
            if (this.MoveToSelectedFunctionsRequested != null)
                this.MoveToSelectedFunctionsRequested(this, e);
        }

        #region IView
        public virtual void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public event EventHandler CloseRequested;
        protected virtual void OnCloseRequested(EventArgs e)
        {
            if (this.CloseRequested != null)
                this.CloseRequested(this, e);
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        new public virtual void ShowDialog()
        {
            throw new NotImplementedException();
        }
        #endregion

        private void move_to_selected_functions_button_Click_1(object sender, RoutedEventArgs e)
        {
            if(this.available_functions_list_box.SelectedIndex != -1)
                this.OnMoveToSelectedFunctionsRequested(new EventArgsWithModel<IFunctionBaseIdentifier>((IFunctionBaseIdentifier)this.available_functions_list_box.SelectedItem));
        }

        private void move_to_available_functions_button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.selected_functions_list_box.SelectedIndex != -1)
                this.OnMoveToAvailableFunctionsRequested(new EventArgsWithModel<IFunctionBaseIdentifier>((IFunctionBaseIdentifier)this.selected_functions_list_box.SelectedItem));
        }

        private void move_all_to_selected_functions_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnMoveAllToSelectedFunctionsRequested(new EventArgs());
        }

        private void move_all_to_available_functions_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnMoveAllToAvailableFunctionsRequested(new EventArgs());
        }

        public IFunctionBaseIdentifier[] AvailableFunctions
        {
            get { return this.available_functions_list_box.Items.Cast<IFunctionBaseIdentifier>().ToArray(); }
            set
            {
                this.available_functions_list_box.Items.Clear();
                foreach (var val in value)
                    this.available_functions_list_box.Items.Add(val);
            }
        }

        public IFunctionBaseIdentifier[] SelectedFunctions
        {
            get { return this.selected_functions_list_box.Items.Cast<IFunctionBaseIdentifier>().ToArray(); }
            set
            {
                this.selected_functions_list_box.Items.Clear();
                foreach (var val in value)
                    this.selected_functions_list_box.Items.Add(val);
            }
        }

        public void AddToAvailableFunctions(IFunctionBaseIdentifier function)
        {
            this.available_functions_list_box.Items.Add(function);
        }

        public void AddToSelectedFunctions(IFunctionBaseIdentifier function)
        {
            this.selected_functions_list_box.Items.Add(function);
        }

        public void RemoveFromAvailableFunctions(IFunctionBaseIdentifier function)
        {
            this.available_functions_list_box.Items.Remove(function);
        }

        public void RemoveFromSelectedFunctions(IFunctionBaseIdentifier function)
        {
            this.selected_functions_list_box.Items.Remove(function);
        }

        private void available_functions_list_box_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.available_functions_list_box.SelectedIndex != -1)
                this.OnMoveToSelectedFunctionsRequested(new EventArgsWithModel<IFunctionBaseIdentifier>((IFunctionBaseIdentifier)this.available_functions_list_box.SelectedItem));
        }

        private void selected_functions_list_box_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.selected_functions_list_box.SelectedIndex != -1)
                this.OnMoveToAvailableFunctionsRequested(new EventArgsWithModel<IFunctionBaseIdentifier>((IFunctionBaseIdentifier)this.selected_functions_list_box.SelectedItem));
        }
    }
}

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
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Codons.CodonConverters;
using GeneticFaradayApplication.Utilities;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.CodonConverters;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes.CodonConverters
{
    /// <summary>
    /// Interaction logic for CodonConvertersView.xaml
    /// </summary>
    public partial class CodonConvertersView : UserControl, ICodonConvertersView
    {
        public CodonConvertersView()
        {
            InitializeComponent();
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

        public event EventHandler MoveAllToAvailableCodonConvertersRequested;
        protected virtual void OnMoveAllToAvailableCodonConvertersRequested(EventArgs e)
        {
            if (this.MoveAllToAvailableCodonConvertersRequested != null)
                this.MoveAllToAvailableCodonConvertersRequested(this, e);
        }

        public event EventHandler MoveAllToSelectedCodonConvertersRequested;
        protected virtual void OnMoveAllToSelectedCodonConvertersRequested(EventArgs e)
        {
            if (this.MoveAllToSelectedCodonConvertersRequested != null)
                this.MoveAllToSelectedCodonConvertersRequested(this, e);
        }

        public event EventHandler<EventArgsWithModel<ICodonConverterIdentifier>> MoveToAvailableCodonConvertersRequested;
        protected virtual void OnMoveToAvailableCodonConvertersRequested(EventArgsWithModel<ICodonConverterIdentifier> e)
        {
            if (this.MoveToAvailableCodonConvertersRequested != null)
                this.MoveToAvailableCodonConvertersRequested(this, e);
        }

        public event EventHandler<EventArgsWithModel<ICodonConverterIdentifier>> MoveToSelectedCodonConvertersRequested;
        protected virtual void OnMoveToSelectedCodonConvertersRequested(EventArgsWithModel<ICodonConverterIdentifier> e)
        {
            if (this.MoveToSelectedCodonConvertersRequested != null)
                this.MoveToSelectedCodonConvertersRequested(this, e);
        }


        private void move_to_selected_codon_converters_button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.available_codon_converters_list_box.SelectedIndex != -1)
                this.OnMoveToSelectedCodonConvertersRequested(new EventArgsWithModel<ICodonConverterIdentifier>((ICodonConverterIdentifier)this.available_codon_converters_list_box.SelectedItem));
        }

        private void move_to_available_codon_converters_button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.selected_codon_converters_list_box.SelectedIndex != -1)
                this.OnMoveToAvailableCodonConvertersRequested(new EventArgsWithModel<ICodonConverterIdentifier>((ICodonConverterIdentifier)this.selected_codon_converters_list_box.SelectedItem));
        }

        private void move_all_to_selected_codon_converters_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnMoveAllToSelectedCodonConvertersRequested(new EventArgs());
        }

        private void move_all_to_available_codon_converters_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnMoveAllToAvailableCodonConvertersRequested(new EventArgs());
        }

        public ICodonConverterIdentifier[] AvailableCodonConverters
        {
            get { return this.available_codon_converters_list_box.Items.Cast<ICodonConverterIdentifier>().ToArray(); }
            set
            {
                this.available_codon_converters_list_box.Items.Clear();
                foreach (var val in value)
                    this.available_codon_converters_list_box.Items.Add(val);
            }
        }

        public ICodonConverterIdentifier[] SelectedCodonConverters
        {
            get { return this.selected_codon_converters_list_box.Items.Cast<ICodonConverterIdentifier>().ToArray(); }
            set
            {
                this.selected_codon_converters_list_box.Items.Clear();
                foreach (var val in value)
                    this.selected_codon_converters_list_box.Items.Add(val);
            }
        }

        public void AddToAvailableCodonConverters(ICodonConverterIdentifier function)
        {
            this.available_codon_converters_list_box.Items.Add(function);
        }

        public void AddToSelectedCodonConverters(ICodonConverterIdentifier function)
        {
            this.selected_codon_converters_list_box.Items.Add(function);
        }

        public void RemoveFromAvailableCodonConverters(ICodonConverterIdentifier function)
        {
            this.available_codon_converters_list_box.Items.Remove(function);
        }

        public void RemoveFromSelectedCodonConverters(ICodonConverterIdentifier function)
        {
            this.selected_codon_converters_list_box.Items.Remove(function);
        }

        private void available_codon_converters_list_box_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.available_codon_converters_list_box.SelectedIndex != -1)
                this.OnMoveToSelectedCodonConvertersRequested(new EventArgsWithModel<ICodonConverterIdentifier>((ICodonConverterIdentifier)this.available_codon_converters_list_box.SelectedItem));
        }

        private void selected_codon_converters_list_box_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (this.selected_codon_converters_list_box.SelectedIndex != -1)
                this.OnMoveToAvailableCodonConvertersRequested(new EventArgsWithModel<ICodonConverterIdentifier>((ICodonConverterIdentifier)this.selected_codon_converters_list_box.SelectedItem));
        }
    }
}

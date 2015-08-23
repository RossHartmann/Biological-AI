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
using GeneticFaraday.Contracts.Organisms.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Utilities;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes.Nucleotides
{
    /// <summary>
    /// Interaction logic for NucleotidesView.xaml
    /// </summary>
    public partial class NucleotidesView : UserControl, INucleotidesView
    {
        public INucleotideEditorModel[] Nucleotides
        {
            get { return this.nucleotides_list_view.Items.Cast<INucleotideEditorModel>().ToArray(); }
            set
            {
                this.nucleotides_list_view.Items.Clear();
                foreach (var val in value)
                    this.nucleotides_list_view.Items.Add(val);
            }
        }

        public void AddNucleotide(INucleotideEditorModel nucleotide)
        {
            this.nucleotides_list_view.Items.Add(nucleotide);
        }

        public void RemoveNucleotide(INucleotideEditorModel nucleotide)
        {
            this.nucleotides_list_view.Items.Remove(nucleotide);
        }

        public void ClearNucleotides()
        {
            this.nucleotides_list_view.Items.Clear();
        }


        public NucleotidesView()
        {
            InitializeComponent();
        }

        public event EventHandler ClearNucleotidesRequested;
        protected virtual void OnClearNucleotidesRequested(EventArgs e)
        {
            if (this.ClearNucleotidesRequested != null)
                this.ClearNucleotidesRequested(this, e);
        }

        public event EventHandler AddNucleotideRequested;
        protected virtual void OnAddNucleotideRequested(EventArgs e)
        {
            if (this.AddNucleotideRequested != null)
                this.AddNucleotideRequested(this, e);
        }

        public event EventHandler<EventArgsWithModel<INucleotideEditorModel>> RemoveNucleotideRequested;
        protected virtual void OnRemoveNucleotideRequested(EventArgsWithModel<INucleotideEditorModel> e)
        {
            if (this.RemoveNucleotideRequested != null)
                this.RemoveNucleotideRequested(this, e);
        }

        public event EventHandler<EventArgsWithModel<INucleotideEditorModel>> ViewNucleotideRequested;
        protected virtual void OnViewNucleotideRequested(EventArgsWithModel<INucleotideEditorModel> e)
        {
            if (this.ViewNucleotideRequested != null)
                this.ViewNucleotideRequested(this, e);
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

        private void add_nucleotide_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnAddNucleotideRequested(new EventArgs());
        }

        private void delete_nucleotide_button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.nucleotides_list_view.SelectedIndex != -1)
                this.OnRemoveNucleotideRequested(new EventArgsWithModel<INucleotideEditorModel>((INucleotideEditorModel)this.nucleotides_list_view.SelectedItem));
        }

        private void clear_nucleotides_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnClearNucleotidesRequested(new EventArgs());
        }

        private void nucleotides_list_view_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(this.nucleotides_list_view.SelectedIndex != -1)
            {
                this.OnViewNucleotideRequested(new EventArgsWithModel<INucleotideEditorModel>((INucleotideEditorModel)this.nucleotides_list_view.SelectedItem));
            }
        }
    }
}

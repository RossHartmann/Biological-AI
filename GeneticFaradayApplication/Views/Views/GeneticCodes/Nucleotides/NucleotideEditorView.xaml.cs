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
using System.Windows.Shapes;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Nucleotides;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes.Nucleotides
{
    /// <summary>
    /// Interaction logic for NucleotideEditorView.xaml
    /// </summary>
    public partial class NucleotideEditorView : Window, INucleotideEditorView
    {
        public string NucleotideIdentifier
        {
            get { return this.nucleotide_identifier_text_box.Text; }
            set { this.nucleotide_identifier_text_box.Text = value; }
        }

        public NucleotideEditorView()
        {
            InitializeComponent();
        }


        public event EventHandler SaveRequested;
        protected virtual void OnSaveRequested(EventArgs e)
        {
            if (this.SaveRequested != null)
                this.SaveRequested(this, e);
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

        new public virtual void ShowDialog()
        {
            base.ShowDialog();
        }
        #endregion

        private void save_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnSaveRequested(new EventArgs());
        }
    }
}

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
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes
{
    /// <summary>
    /// Interaction logic for GeneticCodeSelector.xaml
    /// </summary>
    public partial class GeneticCodeSelectorView : Window, IGeneticCodeSelectorView
    {
        /// <summary>
        /// The name of the selected Genetic Code.
        /// </summary>
        public string SelectedGeneticCodeName
        {
            get { return this.genetic_code_combo_box.Text; }
            set { this.genetic_code_combo_box.Text = value; }
        }

        /// <summary>
        /// The names of the Genetic Codes from which the user can select.
        /// </summary>
        public string[] AvailableGeneticCodeNames
        {
            get { return this.genetic_code_combo_box.Items.Cast<string>().ToArray(); }
            set
            {
                this.genetic_code_combo_box.Items.Clear();
                foreach (var val in value)
                    this.genetic_code_combo_box.Items.Add(val);

                if (this.genetic_code_combo_box.Items.Count > 0)
                    this.genetic_code_combo_box.SelectedIndex = 0;
            }
        }


        public event EventHandler OKButtonClicked;
        protected void OnOKButtonClicked(EventArgs e)
        {
            if (this.OKButtonClicked != null)
                this.OKButtonClicked(this, e);
        }


        public GeneticCodeSelectorView()
        {
            InitializeComponent();
        }

        private void okay_button_Click(object sender, RoutedEventArgs e)
        {
            this.OnOKButtonClicked(new EventArgs());
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
    }
}

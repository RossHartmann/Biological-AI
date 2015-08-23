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
    /// Interaction logic for GeneticCodeCreatorView.xaml
    /// </summary>
    public partial class GeneticCodeCreatorView : Window, IGeneticCodeCreatorView
    {
        /// <summary>
        /// The unique name of the Genetic Code.
        /// </summary>
        public string GeneticCodeName
        {
            get { return this.basic_genetic_code_info.GeneticCodeName; }
            set { this.basic_genetic_code_info.GeneticCodeName = value; }
        }

        /// <summary>
        /// The length of every Codon in the Genetic Code. All Codons must be of this length.
        /// </summary>
        public int CodonLength
        {
            get { return this.basic_genetic_code_info.CodonLength; }
            set
            {
                this.basic_genetic_code_info.CodonLength = value;
            }
        }

        /// <summary>
        /// The maximum number of IFunctions that take parameters 
        /// that can be used in an IAllele's IDNA. After (or before) this 
        /// number of IFunctions (with parameters) have been called, the rest
        /// of the IFunctions in the IDNA will not accept any parameters (i.e. they 
        /// will be terminals).
        /// </summary>
        public int MaxParameterfulFunctionsInDNA
        {
            get { return this.basic_genetic_code_info.MaxParameterfulFunctionsInDNA; }
            set
            {
                this.basic_genetic_code_info.MaxParameterfulFunctionsInDNA = value;
            }
        }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an
        /// IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        public int MaxRecursionLevel
        {
            get { return this.basic_genetic_code_info.MaxRecursionLevel; }
            set { this.basic_genetic_code_info.MaxRecursionLevel = value; }
        }

        public int DNAHeadLength
        {
            get { return this.basic_genetic_code_info.DNAHeadLength; }
            set { this.basic_genetic_code_info.DNAHeadLength = value; }
        }

        public int DNATailLength
        {
            get { return this.basic_genetic_code_info.DNATailLength; }
            set { this.basic_genetic_code_info.DNATailLength = value; }
        }

        public int DNATotalLength
        {
            get { return this.basic_genetic_code_info.DNATotalLength; }
            set { this.basic_genetic_code_info.DNATotalLength = value; }
        }

        public GeneticCodeCreatorView()
        {
            InitializeComponent();
        }


        

        public event EventHandler OKButtonClicked;
        protected void OnOKButtonClicked(EventArgs e)
        {
            if (this.OKButtonClicked != null)
                this.OKButtonClicked(this, e);
        }

        private void ok_button_Click(object sender, RoutedEventArgs e)
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

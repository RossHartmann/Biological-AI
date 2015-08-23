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
using GeneticFaradayApplication.Models.Contracts.GeneticCodes;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Nucleotides;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes;
using GeneticFaradayApplication.Repositories.Contracts;
using GeneticFaradayApplication.Repositories.Repositories;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;
using UtilityData.LINQ;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes
{
    /// <summary>
    /// Interaction logic for GeneticCodeEditorViewBase.xaml
    /// </summary>
    public partial class GeneticCodeEditorView : Window, IGeneticCodeEditorView
    {
        public INucleotidesPresenter NucleotidesPresenter { get; private set; }
        public ICodonsPresenter CodonsPresenter { get; private set; }
        

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

        public GeneticCodeEditorView(INucleotidesPresenter nucleotidesPresenter, 
            ICodonsPresenter codonsPresenter)
        {
            InitializeComponent();

            this.NucleotidesPresenter = nucleotidesPresenter;
            this.CodonsPresenter = codonsPresenter;
            
            this.nucleotides_tab_item.Content = this.NucleotidesPresenter.View;
            this.codons_tab_item.Content = this.CodonsPresenter.View;
            
        }

        /// <summary>
        /// Occurs when a new Genetic Code is requested.
        /// </summary>
        public event EventHandler NewGeneticCode;
        protected void OnNewGeneticCode(EventArgs e)
        {
            if (this.NewGeneticCode != null)
                this.NewGeneticCode(this, e);
        }

        /// <summary>
        /// Occurs when a Genetic Code is loaded.
        /// </summary>
        public event EventHandler LoadGeneticCode;
        protected void OnLoadGeneticCode(EventArgs e)
        {
            if (this.LoadGeneticCode != null)
                this.LoadGeneticCode(this, e);
        }

        /// <summary>
        /// Occurs when a Genetic Code is saved.
        /// </summary>
        public event EventHandler SaveGeneticCode;
        protected void OnSaveGeneticCode(EventArgs e)
        {
            if (this.SaveGeneticCode != null)
                this.SaveGeneticCode(this, e);
        }

        private void NewGeneticCode_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.OnNewGeneticCode(new EventArgs());
        }

        private void OpenGeneticCode_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.OnLoadGeneticCode(new EventArgs());
        }

        private void SaveGeneticCode_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.OnSaveGeneticCode(new EventArgs());
        }
        
        private void ExitGeneticCode_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.OnCloseRequested(new EventArgs());
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

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
using GeneticFaraday.GEP.AbstractModels.Organisms.GeneticCodes;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes;
using UtilityData.LINQ;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes
{
    /// <summary>
    /// Interaction logic for GeneticCodeBasicInfoView.xaml
    /// </summary>
    public partial class GeneticCodeBasicInfoView : UserControl, IBasicGeneticCodeInfoView
    {
        /// <summary>
        /// Indicates whether the Genetic Code Name can be edited.
        /// </summary>
        public bool AllowNameEdit
        {
            get { return this.genetic_code_name_text_box.IsEnabled; }
            set { this.genetic_code_name_text_box.IsEnabled = value; }
        }

        public bool AllowCodonLengthEdit
        {
            get { return this.codon_length_text_box.IsEnabled; }
            set { this.codon_length_text_box.IsEnabled = value; }
        }

        /// <summary>
        /// The unique name of the Genetic Code.
        /// </summary>
        public string GeneticCodeName
        {
            get { return this.genetic_code_name_text_box.Text; }
            set { this.genetic_code_name_text_box.Text = value; }
        }

        /// <summary>
        /// The length of every Codon in the Genetic Code. All Codons must be of this length.
        /// </summary>
        public int CodonLength
        {
            get
            {
                return this.codon_length_text_box.Text.IsInt() ? this.codon_length_text_box.Text.ToInt() : 0;
            }
            set
            {
                this.codon_length_text_box.Text = value.ToString();
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
            get { return this.max_parameterful_functions_in_dna_text_box.Text.IsInt() ? this.max_parameterful_functions_in_dna_text_box.Text.ToInt() : 0; }
            set
            {
                this.max_parameterful_functions_in_dna_text_box.Text = value.ToString();
            }
        }

        /// <summary>
        /// The maximum recursion level that's allowable. If this value is reached by an
        /// IGEPGene, the execution of the IGEPGene will be aborted.
        /// </summary>
        public int MaxRecursionLevel
        {
            get { return this.max_recursion_level_text_box.Text.IsInt() ? this.max_recursion_level_text_box.Text.ToInt() : 0; }
            set { this.max_recursion_level_text_box.Text = value.ToString(); }
        }

        public int DNAHeadLength
        {
            get { return this.dna_head_length_text_box.Text.IsInt() ? this.dna_head_length_text_box.Text.ToInt() : 0; }
            set { this.dna_head_length_text_box.Text = value.ToString(); }
        }

        public int DNATailLength
        {
            get { return this.dna_tail_length_text_box.Text.IsInt() ? this.dna_tail_length_text_box.Text.ToInt() : 0; }
            set { this.dna_tail_length_text_box.Text = value.ToString(); }
        }

        public int DNATotalLength
        {
            get { return this.dna_total_length_text_box.Text.IsInt() ? this.dna_total_length_text_box.Text.ToInt() : 0; }
            set { this.dna_total_length_text_box.Text = value.ToString(); }
        }

        public GeneticCodeBasicInfoView()
        {
            InitializeComponent();

            this.max_parameterful_functions_in_dna_text_box.TextChanged += max_parameterful_functions_in_dna_text_box_TextChanged;
            this.codon_length_text_box.TextChanged += codon_length_text_box_TextChanged;

            this.UpdateDNALengthFields();
        }

        void codon_length_text_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.UpdateDNALengthFields();
        }

        void max_parameterful_functions_in_dna_text_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.UpdateDNALengthFields();
        }


        public void UpdateDNALengthFields()
        {
            var dnaHeadLength =
                GEPGeneticCodeBase.CalculateDNAHeadLength(
                    maxParameterfulFunctionsInDNA: this.MaxParameterfulFunctionsInDNA, codonLength: this.CodonLength);
            var dnaTailLength =
                GEPGeneticCodeBase.CalculateDNATailLength(dnaHeadLength: dnaHeadLength, maximumFunctionInputsUsed: 0,
                                                          codonLength: this.CodonLength);
            var dnaLength =
                GEPGeneticCodeBase.CalculateDNALength(dnaHeadLength: dnaHeadLength, dnaTailLength: dnaTailLength);

            this.DNAHeadLength = dnaHeadLength;
            this.DNATailLength = dnaTailLength;
            this.DNATotalLength = dnaLength;
        }
    }
}

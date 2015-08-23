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
using GeneticFaraday.GEP.Contracts.Organisms.GeneticCodes.Functions;
using GeneticFaraday.GEP.Models.Environment;
using GeneticFaradayApplication.Models.AbstractModels.GeneticCodes.Functions;
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.CodonConverters;
using GeneticFaradayApplication.Presenters.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;
using GeneticFaradayApplication.Views.Views.GeneticCodes.Functions;
using UtilityData.LINQ;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes.Codons
{
    /// <summary>
    /// Interaction logic for CodonsCreatorView.xaml
    /// </summary>
    public partial class CodonsCreatorView : Window, ICodonsCreatorView
    {
        public double MaxCodonCount
        {
            get
            {
                return this.Dispatcher.Invoke(new Func<double>(() => this.progress_bar.Maximum));
            }
            set { this.Dispatcher.Invoke(() => { this.progress_bar.Maximum = value; }); }
        }

        public double CurrentCodonsCreated
        {
            get
            {
                return this.Dispatcher.Invoke(new Func<double>(() => this.progress_bar.Value));
            }
            set { this.Dispatcher.Invoke(() => { this.progress_bar.Value = value; }); }
        }

        public double StopCodonPercentage
        {
            get
            {
                return this.Dispatcher.Invoke(new Func<double>(() =>
                                                            {
                                                                if (!this.stop_codon_percentage_text_box.Text.IsDouble())
                                                                    return 0;

                                                                return
                                                                    this.stop_codon_percentage_text_box.Text.ToDouble();
                                                            }));
            }
            set
            {
                this.Dispatcher.Invoke(() => { this.stop_codon_percentage_text_box.Text = value.ToString(); }); 
            }
        }

        public int RedundancyRating
        {
            get
            {
                return this.Dispatcher.Invoke(new Func<int>(() =>
                {
                    if (!this.redundancy_rating_text_box.Text.IsInt())
                        return 0;

                    return this.redundancy_rating_text_box.Text.ToInt();
                }));
                
            }
            set
            {
                this.Dispatcher.Invoke(() => { this.redundancy_rating_text_box.Text = value.ToString(); }); 
                
            }
        }

        public IFunctionsPresenter FunctionsPresenter { get; private set; }
        public ICodonConvertersPresenter CodonConvertersPresenter { get; private set; }

        /// <summary>
        /// The functions for which the Codons will encode.
        /// </summary>
        public List<IFunction> Functions { get; set; } 

        public CodonsCreatorView(IFunctionsPresenter functionsPresenter, ICodonConvertersPresenter codonConvertersPresenter)
        {
            InitializeComponent();

            this.FunctionsPresenter = functionsPresenter;
            this.CodonConvertersPresenter = codonConvertersPresenter;

            this.functions_tab_item.Content = this.FunctionsPresenter.View;
            this.codon_converters_tab_item.Content = this.CodonConvertersPresenter.View;
        }

        public event EventHandler FunctionsCreated;
        protected virtual void OnFunctionsCreated(EventArgs e)
        {
            if (this.FunctionsCreated != null)
                this.FunctionsCreated(this, e);
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

        private void refresh_button_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedFunctionIdentifiers = this.FunctionsPresenter.View.SelectedFunctions;

            const int height = 63;

            var currentHeight = 0d;
            this.weight_grid.Height = (2 * selectedFunctionIdentifiers.Length*height) + height;
            this.weight_grid.UpdateLayout();
            this.weight_grid.Children.Clear();
            foreach(var function in selectedFunctionIdentifiers)
            {
                var functionWeightPresenter = new FunctionWeightPresenter(function);
                var functionWeightView = (UserControl)functionWeightPresenter.View;
                functionWeightView.Margin = new Thickness(0, currentHeight, 0, currentHeight + height);
                this.weight_grid.Children.Add(functionWeightView);
                
                currentHeight += height;
            }
        }

        private void create_codons_button_Click_1(object sender, RoutedEventArgs e)
        {
            var codonConverters = this.CodonConvertersPresenter.View.SelectedCodonConverters;

            this.Functions = new List<IFunction>();
            foreach(FunctionWeightView functionWeightView in this.weight_grid.Children)
            {
                var functionBaseIdentifier = functionWeightView.FunctionBaseIdentifier;
                functionBaseIdentifier.WeightInGeneticCode = functionWeightView.WeightInGeneticCode;

                this.Functions.AddRange(FunctionsModelBase.GetFunctions(GEPEnvironment.GetAllWriteableRegistryIdentifiers(),
                                                                   GEPEnvironment.GetAllRegistryIdentifiers(),
                                                                   codonConverters, functionBaseIdentifier));
            }

            this.OnFunctionsCreated(new EventArgs());
        }

        public void DisableControls()
        {
            this.create_codons_button.IsEnabled = false;
            this.codon_converters_tab_item.IsEnabled = false;
            this.functions_tab_item.IsEnabled = false;
            this.weight_grid.IsEnabled = false;
            this.stop_codon_percentage_text_box.IsEnabled = false;
            this.redundancy_rating_text_box.IsEnabled = false;
        }
    }
}

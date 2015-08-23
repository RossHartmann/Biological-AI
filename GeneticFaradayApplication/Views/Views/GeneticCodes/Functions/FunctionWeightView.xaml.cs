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
using GeneticFaradayApplication.Models.Contracts.GeneticCodes.Functions;
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Functions;
using UtilityData.LINQ;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes.Functions
{
    /// <summary>
    /// Interaction logic for FunctionWeightView.xaml
    /// </summary>
    public partial class FunctionWeightView : UserControl, IFunctionWeightView
    {
        public IFunctionBaseIdentifier FunctionBaseIdentifier { get; set; }

        public double WeightInGeneticCode
        {
            get { return this.weight_slider.Value; }
            set
            {
                this.weight_slider.Value = value;
            }
        }

        public FunctionWeightView()
        {
            InitializeComponent();

            this.weight_slider.ValueChanged += weight_slider_ValueChanged;
            this.value_text_box.TextChanged += value_text_box_TextChanged;
        }

        void value_text_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!value_text_box.Text.IsDouble())
                return;

            var value = value_text_box.Text.ToDouble();
            if (value > this.weight_slider.Maximum)
            {
                this.weight_slider.Value = this.weight_slider.Maximum;
                this.value_text_box.Text = this.weight_slider.Maximum.ToString();
            }
            else if (value < this.weight_slider.Minimum)
            {
                this.weight_slider.Value = this.weight_slider.Minimum;
                this.value_text_box.Text = this.weight_slider.Minimum.ToString();
            }
            else
                this.weight_slider.Value = value;
        }

        void weight_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(this.value_text_box.Text != e.NewValue.ToString())
                this.value_text_box.Text = e.NewValue.ToString();
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

        
        public void SetFunctionName(string functionName)
        {
            this.function_name_label.Content = functionName;
        }
    }
}

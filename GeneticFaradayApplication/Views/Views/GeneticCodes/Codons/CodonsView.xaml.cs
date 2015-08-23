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
using GeneticFaradayApplication.Views.Contracts.GeneticCodes.Codons;

namespace GeneticFaradayApplication.Views.Views.GeneticCodes.Codons
{
    /// <summary>
    /// Interaction logic for CodonsView.xaml
    /// </summary>
    public partial class CodonsView : UserControl, ICodonsView
    {
        public CodonsView()
        {
            InitializeComponent();
        }

        public event EventHandler CreateCodonsRequested;
        protected virtual void OnCreateCodonsRequested(EventArgs e)
        {
            if (this.CreateCodonsRequested != null)
                this.CreateCodonsRequested(this, e);
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

        private void create_codons_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnCreateCodonsRequested(new EventArgs());
        }
    }
}

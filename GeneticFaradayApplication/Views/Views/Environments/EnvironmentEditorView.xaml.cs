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
using GeneticFaradayApplication.Views.Contracts.Environments;

namespace GeneticFaradayApplication.Views.Views.Environments
{
    /// <summary>
    /// Interaction logic for EnvironmentEditorView.xaml
    /// </summary>
    public partial class EnvironmentEditorView : Window, IEnvironmentEditorView
    {
        public EnvironmentEditorView()
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

        new public virtual void ShowDialog()
        {
            base.ShowDialog();
        }
        #endregion
    }
}

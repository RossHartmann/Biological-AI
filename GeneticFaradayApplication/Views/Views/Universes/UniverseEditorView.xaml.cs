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
using GeneticFaradayApplication.Presenters.Contracts.Universes;
using GeneticFaradayApplication.Views.Contracts.Universes;

namespace GeneticFaradayApplication.Views.Views.Universes
{
    /// <summary>
    /// Interaction logic for UniverseEditor.xaml
    /// </summary>
    public partial class UniverseEditorView : Window, IUniverseEditorView
    {
        
        public UniverseEditorView()
        {
            InitializeComponent();
        }

        public void AddEnvironment(IEnvironmentSummaryPresenter environmentSummaryPresenter, string title)
        {
            var tabItem = new TabItem();
            tabItem.Header = title;
            tabItem.Content = environmentSummaryPresenter.View;
            this.tab_control.Items.Add(tabItem);
        }

        public event EventHandler AddEnvironmentRequested;
        protected virtual void OnAddEnvironmentRequested(EventArgs e)
        {
            if (this.AddEnvironmentRequested != null)
                this.AddEnvironmentRequested(this, e);
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

        private void add_environment_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnAddEnvironmentRequested(new EventArgs());
        }
    }
}

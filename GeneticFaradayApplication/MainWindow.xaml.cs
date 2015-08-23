using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using GeneticFaradayApplication.Models.Models.GeneticCodes;
using GeneticFaradayApplication.Presenters.Presenters.GeneticCodes;
using GeneticFaradayApplication.Presenters.Presenters.Universes;
using GeneticFaradayApplication.Views.Views.GeneticCodes;
using GeneticFaradayDatabaseLibrary;
using GeneticFaradayDatabaseLibrary.GeneticFaradayDatabase.StrongTables;
using UtilityData.Database;
using UtilityData.SQL;

namespace GeneticFaradayApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var sqlConnectionDetails = new SQLConnectionDetails(DatabaseType.MSSQL, System.Configuration.ConfigurationManager.ConnectionStrings["Production"].ConnectionString);
            SM.Initialize(sqlConnectionDetails.Server, recordAllSQLTransactions: false);
            DM.Initialize(new SqlConnection(sqlConnectionDetails.ConnectionString).Database, sqlConnectionDetails, new SessionManager());
            
        }

        private void FileExit_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void new_genetic_code_menu_item_Click_1(object sender, RoutedEventArgs e)
        {
            var geneticCodeCreator = new GeneticCodeCreatorPresenter();
            geneticCodeCreator.ShowDialog();

            if(geneticCodeCreator.Model.GeneticCodePrimaryKey != null)
            {
                var geneticCodeEditorPresenter = new GeneticCodeEditorPresenter(new GeneticCodeEditorModel(
                                                                                    geneticCodePrimaryKey:
                                                                                        geneticCodeCreator.Model.
                                                                                        GeneticCodePrimaryKey.Value));
                geneticCodeEditorPresenter.Show();
            }
        }

        private void open_genetic_code_menu_item_Click_1(object sender, RoutedEventArgs e)
        {
            var geneticCodeSelector = new GeneticCodeSelectorPresenter();
            geneticCodeSelector.ShowDialog();

            var selectedGeneticCode = geneticCodeSelector.View.SelectedGeneticCodeName;

            if (!string.IsNullOrEmpty(selectedGeneticCode))
            {
                var geneticCodeEditorPresenter = new GeneticCodeEditorPresenter(new GeneticCodeEditorModel(
                                                                                    geneticCodeName: selectedGeneticCode));
                geneticCodeEditorPresenter.Show();
            }
        }

        private void new_universe_menu_item_Click_1(object sender, RoutedEventArgs e)
        {
            var universeEditorPresenter = new UniverseEditorPresenter();
            universeEditorPresenter.Show();
        }
    }
}
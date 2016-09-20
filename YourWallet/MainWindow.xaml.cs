using System;
using System.Collections.Generic;
using System.Data;
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

namespace YourWallet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            YourWallet.databaseSet databaseSet = ((YourWallet.databaseSet)(this.FindResource("databaseSet")));
            // Load data into the table Tablica. You can modify this code as needed.
            YourWallet.databaseSetTableAdapters.TablicaTableAdapter databaseSetTablicaTableAdapter = new YourWallet.databaseSetTableAdapters.TablicaTableAdapter();
            databaseSetTablicaTableAdapter.Fill(databaseSet.Tablica);
            System.Windows.Data.CollectionViewSource tablicaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tablicaViewSource")));
            tablicaViewSource.View.MoveCurrentToFirst();
        }
    }
}

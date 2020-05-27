using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml;

namespace ProgramowanieProjekt
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        public ListWindow()
        {
            InitializeComponent();
            DataSet recipes = new DataSet();
            recipes.ReadXml("../../recipes.xml");
            recipeList.ItemsSource = recipes.Tables[0].DefaultView;
        }
        private void OpenMain(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}

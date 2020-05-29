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
using System.Xml;
using System.Xml.Linq;

namespace ProgramowanieProjekt
{
    /// <summary>
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            InitializeComponent();
        }
        private void OpenMain(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
        private void SubmitRecipe(object sender, RoutedEventArgs e)
        {
            XDocument recipes = XDocument.Load("../../recipes.xml");

            int nodeCount = 0;
            using (var reader = XmlReader.Create("../../recipes.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "recipe")
                    {
                        nodeCount++;
                    }
                }
            }


            XElement recipe = new XElement("recipe", new XAttribute("id", nodeCount + 1),
                new XElement("name", recipeName.Text),
                new XElement("timeRequired", time.Text),
                new XElement("cost", cost.Text),
                new XElement("difficulty", difficulty.SelectedIndex+1),
                new XElement("ingredients", ingredients.Text),
                new XElement("steps", steps.Text));
            recipes.Root.Add(recipe);
            recipes.Save("../../recipes.xml");

            DisplayWindow window = new DisplayWindow(nodeCount + 1);
            this.Close();
            window.Show();
        }
    }
}

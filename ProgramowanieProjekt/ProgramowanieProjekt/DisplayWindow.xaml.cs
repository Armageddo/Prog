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

namespace ProgramowanieProjekt
{
    /// <summary>
    /// Interaction logic for DisplayWindow.xaml
    /// </summary>
    public partial class DisplayWindow : Window
    {
        public DisplayWindow(int id)
        {
            
            InitializeComponent();
            XmlDocument recipes = new XmlDocument();
            recipes.Load("../../recipes.xml");
            XmlElement root = recipes.DocumentElement;
            XmlNodeList nodes = root.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                if(id == 0)
                {
                    Random rand = new Random();
                    id = rand.Next(1, nodes.Count+1);
                }
                if (int.Parse(node.Attributes[0].Value) == id){
                    recipeName.Text = node.ChildNodes.Item(0).InnerText;
                    time.Text = node.ChildNodes.Item(1).InnerText + " min";
                    cost.Text = node.ChildNodes.Item(2).InnerText + " zł";
                    difficulty.Text = node.ChildNodes.Item(3).InnerText + "/5";
                    ingredients.Text = node.ChildNodes.Item(4).InnerText;
                    steps.Text = node.ChildNodes.Item(5).InnerText;
                }
            }
            
        }
        private void OpenMain(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}

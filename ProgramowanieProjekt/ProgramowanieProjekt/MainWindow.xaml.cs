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

namespace ProgramowanieProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenDisplayRandom(object sender, RoutedEventArgs e)
        {
            DisplayWindow window = new DisplayWindow(0);
            this.Visibility = Visibility.Hidden;
            window.Show();
        }
        private void OpenList(object sender, RoutedEventArgs e)
        {
            ListWindow window = new ListWindow();
            this.Visibility = Visibility.Hidden;
            window.Show();
        }
        private void OpenCreate(object sender, RoutedEventArgs e)
        {
            CreateWindow window = new CreateWindow();
            this.Visibility = Visibility.Hidden;
            window.Show();
        }
    }
}

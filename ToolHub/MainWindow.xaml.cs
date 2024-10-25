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

namespace ToolHub
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChatGPT_Click(object sender, RoutedEventArgs e)
        {
            // Logique pour afficher ou charger l'outil ChatGPT
        }

        private void Spotify_Click(object sender, RoutedEventArgs e)
        {
            // Logique pour afficher ou charger l'outil Spotify
        }

        private void OtherTool_Click(object sender, RoutedEventArgs e)
        {
            // Logique pour afficher ou charger d'autres outils
        }

    }
}

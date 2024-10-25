using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using SpotifyAPI.Web;

namespace ToolHub
{
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
            // Logique pour afficher ou charger l'outil ChatGPT
        }
    }
}

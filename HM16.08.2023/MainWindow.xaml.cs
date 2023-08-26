using HM16._08._2023.Data;
using PropertyChanged;
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

namespace HM16._08._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        MusicAppDbContext db = null;
        public MainWindow()
        {
            InitializeComponent();
            db = new();
        }

        private void Albums_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = db.Albums;
        }

        private void Artists_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource= db.Artists;
        }

        private void Playlists_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = db.Playlists;
        }

        private void Tracks_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = db.Tracks;
        }

        private void AddPlaylists_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}

using HM16._08._2023.Data;
using Microsoft.EntityFrameworkCore;
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
            db.Albums.Include(x => x.Artists)
                     .Include(x => x.Ganre);
            DataGrid.ItemsSource = db.Albums.ToList();
        }

        private void Artists_Selected(object sender, RoutedEventArgs e)
        {
            db.Artists.Include(x => x.Countries);
            DataGrid.ItemsSource= db.Artists.ToList();
        }

        private void Playlists_Selected(object sender, RoutedEventArgs e)
        {
            db.Artists.Include(x => x.Countries);
            DataGrid.ItemsSource = db.Playlists.ToList();
        }

        private void Tracks_Selected(object sender, RoutedEventArgs e)
        {
            db.Tracks.Include(x => x.Albums);
            DataGrid.ItemsSource = db.Tracks.ToList();
        }

        private void addPlaylist_Click(object sender, RoutedEventArgs e)
        {
            AddPlaylist addPlaylist = new AddPlaylist();
            addPlaylist.ShowDialog();
            db.SaveChanges();
        }
    }
}

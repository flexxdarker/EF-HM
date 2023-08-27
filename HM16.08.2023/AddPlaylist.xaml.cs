using HM16._08._2023.Data;
using HM16._08._2023.Entities;
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
    /// Interaction logic for AddPlaylist.xaml
    /// </summary>
    public partial class AddPlaylist : Window
    {
        MusicAppDbContext db = new MusicAppDbContext();
        public AddPlaylist()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            db.Playlists.Add(new Playlists 
            {
                Name = this.name.Text,
                CategoryId = Convert.ToInt32(this.Category.Text),
                
            });
            db.SaveChanges();
            this.Close();
        }
    }
}

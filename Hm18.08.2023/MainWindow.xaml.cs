using DbTo18._08._2023.Data;
using Microsoft.EntityFrameworkCore;
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

namespace Hm18._08._2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirportDbContext db = new(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowAccounts_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = db.Accounts.ToList();
        }

        private void ShowAirplanes_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = db.Airplanes.ToList();
        }

        private void ShowClients_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = db.Clients.ToList();
        }

        private void ShowFlights_Selected(object sender, RoutedEventArgs e)
        {
            db.Flights.Include(x => x.Clients)
                      .Include(x => x.Airplanes);
            DataGrid.ItemsSource = db.Flights.ToList();
        }
    }
}

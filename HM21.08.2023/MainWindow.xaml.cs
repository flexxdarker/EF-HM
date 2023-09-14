using DbToHM21._08._2023.Data;
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

namespace HM21._08._2023
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
        ShopDbContext shopDbContext = new ShopDbContext();
        private void ShowAllWorkers_Selected(object sender, RoutedEventArgs e)
        {
            shopDbContext.Worker.Include(x => x.Shop).Include(x=>x.Position).ToList();
            DataGrid.ItemsSource = shopDbContext.Worker.ToList();
        }

        private void ShowAllProducts_Selected(object sender, RoutedEventArgs e)
        {
            var products = shopDbContext.Products.Find(1);
            shopDbContext.Entry(products).Reference(x => x.Category).LoadAsync();
            DataGrid.ItemsSource = shopDbContext.Products.ToList();
        }

        private void ShowAllShops_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = shopDbContext.Shop.ToList();
        }
    }
}

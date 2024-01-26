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
using Ak_Bars_Galeryyy.Models;
namespace Ak_Bars_Galeryyy.Windows
{
    /// <summary>
    /// Логика взаимодействия для NewCollectionWindow.xaml
    /// </summary>
    public partial class NewCollectionWindow : Window
    {
        public NewCollectionWindow()
        {
            InitializeComponent();
            var newcollection = Ak_Bars_GalleryyyEntities.GetContext().Newcollections.ToList();
            LViewNewCollction.ItemsSource = newcollection;
        }

        private void btnGlavn_Click(object sender, RoutedEventArgs e)
        {
            AboutGalleryWindow aboutGalleryWindow = new AboutGalleryWindow();
            this.Hide();
            aboutGalleryWindow.Show();
        }

        private void jivopis_Click(object sender, RoutedEventArgs e)
        {

            ArtWindow artWindow = new ArtWindow();

            this.Hide();
            artWindow.Show();
        }

        private void btnartist_Click(object sender, RoutedEventArgs e)
        {
            ArtistWindow artistWindow = new ArtistWindow();
            this.Hide();
            artistWindow.Show();
        }

        private void btnaboutgalary_Click(object sender, RoutedEventArgs e)
        {
            AboutGalleryWindow aboutGalleryWindow = new AboutGalleryWindow();
            this.Hide();
            aboutGalleryWindow.Show();
        }

        private void btnPredzakaz_Click(object sender, RoutedEventArgs e)
        {
            BuyNCWindow buyNCWindow = new BuyNCWindow();
            this.Hide();
            buyNCWindow.Show();
        }
    }
}

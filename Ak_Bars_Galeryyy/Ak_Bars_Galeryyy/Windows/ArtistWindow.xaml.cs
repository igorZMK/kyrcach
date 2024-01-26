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
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using Ak_Bars_Galeryyy.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace Ak_Bars_Galeryyy.Windows
{
    /// <summary>
    /// Логика взаимодействия для ArtistWindow.xaml
    /// </summary>
    public partial class ArtistWindow : Window
    {
        public ArtistWindow()
        {
            InitializeComponent();
            var artist = Ak_Bars_GalleryyyEntities.GetContext().Artists.ToList();
            artistListView.ItemsSource = artist;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton != null)
            {
                var artist = Ak_Bars_GalleryyyEntities.GetContext().Artists.ToList();
                
                string buttonText = clickedButton.Content.ToString();
                
                artist = artist.Where(p => p.FIO[0]==buttonText[0]).ToList();
                    artistListView.ItemsSource = artist;
                    
                
            }

        }

        private void collectionbutton_Click(object sender, RoutedEventArgs e)
        {
            NewCollectionWindow newCollectionWindow = new NewCollectionWindow();
            this.Hide();
            newCollectionWindow.Show();
        }

        private void btnaboutgalary_Click(object sender, RoutedEventArgs e)
        {
            AboutGalleryWindow aboutGalleryWindow = new AboutGalleryWindow();

            this.Hide();
            aboutGalleryWindow.Show();
        }

        private void btnnovayacolectia_Click(object sender, RoutedEventArgs e)
        {
            NewCollectionWindow newCollectionWindow = new NewCollectionWindow();

            this.Hide();
            newCollectionWindow.Show();
        }

        private void btnGlavn_Click(object sender, RoutedEventArgs e)
        {
            BasicWindow mainGallery = new BasicWindow();

            this.Hide();
            mainGallery.Show();
        }

        private void jivopis_Click(object sender, RoutedEventArgs e)
        {
            ArtWindow artWindow = new ArtWindow();
            this.Hide();
            artWindow.Show();
        }
    }
}

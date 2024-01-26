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
    /// Логика взаимодействия для ArtWindow.xaml
    /// </summary>
    public partial class ArtWindow : Window
    {
        
        public ArtWindow()
        {

            InitializeComponent();
            var exibits = Ak_Bars_GalleryyyEntities.GetContext().Exibits.ToList();
            
            LViewExibit.ItemsSource = exibits;
        }

        private void btnGlavn_Click(object sender, RoutedEventArgs e)
        {
            BasicWindow mainGallery = new BasicWindow();

            this.Hide();
            mainGallery.Show();
        }

        private void btnaboutgalary_Click(object sender, RoutedEventArgs e)
        {
            AboutGalleryWindow aboutGalleryWindow = new AboutGalleryWindow();

            this.Hide();
            aboutGalleryWindow.Show();
        }

        private void btnartist_Click(object sender, RoutedEventArgs e)
        {
            ArtistWindow artistWindow = new ArtistWindow();

            this.Hide();
            artistWindow.Show();
        }

        private void btnnovayacolectia_Click(object sender, RoutedEventArgs e)
        {
            NewCollectionWindow newCollectionWindow = new NewCollectionWindow();

            this.Hide();
            newCollectionWindow.Show();
        }

        
    }
}

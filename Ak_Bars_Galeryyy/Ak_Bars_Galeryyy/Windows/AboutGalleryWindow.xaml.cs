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

namespace Ak_Bars_Galeryyy.Windows
{
    /// <summary>
    /// Логика взаимодействия для AboutGalleryWindow.xaml
    /// </summary>
    public partial class AboutGalleryWindow : Window
    {
        public AboutGalleryWindow()
        {
            InitializeComponent();
        }

        private void btnartist_Click(object sender, RoutedEventArgs e)
        {
            ArtistWindow artistWindow = new ArtistWindow();
            this.Hide();
            artistWindow.Show();
        }

        private void jivopis_Click(object sender, RoutedEventArgs e)
        {
            ArtWindow artWindow = new ArtWindow();
            this.Hide();
            artWindow.Show();
        }

        private void btnnovayacolectia_Click(object sender, RoutedEventArgs e)
        {
            NewCollectionWindow newCollectionWindow = new NewCollectionWindow();
            this.Hide();
            newCollectionWindow.Show();
        }

        private void btnGlavn_Click(object sender, RoutedEventArgs e)
        {
            BasicWindow basicWindow = new BasicWindow();
            this.Hide();
            basicWindow.Show();
        }
    }
}

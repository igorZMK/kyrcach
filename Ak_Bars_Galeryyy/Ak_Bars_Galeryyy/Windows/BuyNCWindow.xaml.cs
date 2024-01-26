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
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Shapes;
using Ak_Bars_Galeryyy.Models;

namespace Ak_Bars_Galeryyy.Windows
{
    /// <summary>
    /// Логика взаимодействия для BuyNCWindow.xaml
    /// </summary>
    public partial class BuyNCWindow : Window
    {
        public BuyNCWindow()
        {
            InitializeComponent();
            cbName.ItemsSource = Ak_Bars_GalleryyyEntities.GetContext().Newcollections.ToList();

        }
        private StringBuilder CheckFields()
        {
            StringBuilder s = new StringBuilder();

            if (cbName.SelectedIndex == -1)
                s.AppendLine("Выберите картину");
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
                s.AppendLine("Укажите телефон");
            if (string.IsNullOrWhiteSpace(tbRealName.Text))
                s.AppendLine("Укажите настоящее имя");
            return s;
        } 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder _error = CheckFields();
            
            if (_error.Length > 0)
            {
                MessageBox.Show(_error.ToString());
                return;
            }
            Buy buy = new Buy()
            {
                Name_Id = (cbName.SelectedItem as Newcollection).NewCollection_Id,
                Price_Id = Convert.ToInt32(tbPrice.Text),
                Phone = tbPhone.Text,
                RealName = tbRealName.Text,
            };
            Ak_Bars_GalleryyyEntities.GetContext().Buys.Add(buy);
            Ak_Bars_GalleryyyEntities.GetContext().SaveChanges();
            MessageBox.Show("Заявка подана");
            


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewCollectionWindow newCollectionWindow = new NewCollectionWindow();

            this.Hide();
            newCollectionWindow.Show();
        }

        private void cbName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbName.SelectedItem != null)
            {
                tbPrice.Text = (cbName.SelectedItem as Newcollection).Price.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Ak_Bars_Galeryyy.Windows;
using System;
using System.Windows;
using Ak_Bars_Galeryyy.Models;


namespace Ak_Bars_Galeryyy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Password;

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Ak_bars_galleryyy;";
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Авторизация успешна");

                        BasicWindow mainGallery = new BasicWindow();
                        
                        this.Hide();
                        mainGallery.Show();
                    }
                    else
                    {
                        MessageBox.Show("Некорректный логин или пароль");
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegestrationWindow regestrationWindow = new RegestrationWindow();
            
            this.Hide();
            regestrationWindow.Show();
        }
    }
}

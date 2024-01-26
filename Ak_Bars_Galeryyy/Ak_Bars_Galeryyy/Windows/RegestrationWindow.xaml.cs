using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using Ak_Bars_Galeryyy.Models;


namespace Ak_Bars_Galeryyy.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegestrationWindow.xaml
    /// </summary>
    public partial class RegestrationWindow : Window
    {
        public RegestrationWindow()
        {
            InitializeComponent();
            genderComboBox.ItemsSource = Ak_Bars_GalleryyyEntities.GetContext().Genders.ToList();
            levelComboBox.ItemsSource = Ak_Bars_GalleryyyEntities.GetContext().Lvls.ToList();

        }
        private StringBuilder CheckFields()
        {
            StringBuilder s = new StringBuilder();

            
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
                s.AppendLine("Укажите логин");
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
                s.AppendLine("Укажите пароль");
            if (string.IsNullOrWhiteSpace(ageTextBox.Text))
                s.AppendLine("Укажите возраст");
            if (genderComboBox.SelectedIndex == -1)
                s.AppendLine("Выберите пол");
            if (levelComboBox.SelectedIndex == -1)
                s.AppendLine("Выберите уровень");
            if (string.IsNullOrWhiteSpace(ageTextBox.Text))
                s.AppendLine("Укажите настоящее имя");
            return s;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder _error = CheckFields();
            if (_error.Length > 0)
            { MessageBox.Show(_error.ToString());
                return;
            }
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Ak_bars_galleryyy;"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Users (username, password, age, gender, lvl, name) VALUES (@Username, @Password, @Age, @Gender, @Lvl, @Name)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    User Username = (User)Ak_Bars_GalleryyyEntities.GetContext().Users.FirstOrDefault(p => p.Username == usernameTextBox.Text);
                    if (Username != null)
                    {
                        MessageBox.Show("Логин уже существует, введите другой");
                        return;
                    }
                    command.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar) { Value = usernameTextBox.Text });
                    command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar) { Value = passwordBox.Password });
                    command.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int) { Value = int.Parse(ageTextBox.Text) });
                    command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.VarChar) { Value = (genderComboBox.SelectedItem as Gender).Gender_Id });
                    command.Parameters.Add(new SqlParameter("@Lvl", SqlDbType.VarChar) { Value = (levelComboBox.SelectedItem as Lvl).Lvl_Id });
                    command.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar) { Value = nameTextBox.Text });


                    command.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегистрировались");
                    BasicWindow basicWindow = new BasicWindow();
                    this.Hide();
                    basicWindow.Show();
                }
            }
        }
    }
}

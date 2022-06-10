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
using System.Data.SqlClient;

namespace logistic
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

        private void Btn_Check_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text;
            string pass = passwordBox.Password;
            for (int i = login.Length; i < 20; i++)
            {
                login += " ";
            }
            for (int i = pass.Length; i < 20; i++)
            {
                pass += " ";
            }
            int chet = 0;

            string table = "users"; //Имя таблицы
            string ssql = $"SELECT  * FROM {table} "; //Запрос 
            string connectionString = @"Data Source=NITRO\SQLEXPRESS;Initial Catalog=logistic;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов
            SqlDataReader reader = command.ExecuteReader(); // Выаолнение запроса вывод информации
            while (reader.Read())
            {
                if (reader[1] + "" == login && reader[2] + "" == pass)
                {
                    if (reader[0] + "" == "1")
                    {
                        AdminMain main = new AdminMain();
                        main.Show();
                        Close();
                    }
                    else if (reader[0] + "" == "2" || reader[0] + "" == "3")
                    {
                        DispMain main = new DispMain();
                        main.Show();
                        Close();
                    }
                    chet++;
                }
            }
            if (chet == 0) MessageBox.Show("Неверный логин или пароль!");
        }
    }
}

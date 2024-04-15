using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KomissarovPractika
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        

        private void back(object sender, RoutedEventArgs e)
        {
            MainWindow window = new();

            window.Show();
            Close();

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void izmenit(object sender, RoutedEventArgs e)
        {
            Vivod2.Text = "";
            Vivod2.Text = "";
            Vivod2.Text = "";
            Lgn.BorderBrush = new SolidColorBrush(Colors.Gray);
            Eml.BorderBrush = new SolidColorBrush(Colors.Gray);
            Psw.BorderBrush = new SolidColorBrush(Colors.Gray);

            int Errors = 0;

            var login = Lgn.Text;

            var email = Eml.Text;

            var pass = Psw.Text;

            var context = new AppDbContext();

            do
            {
                if (login.Length == 0)
                {
                    Vivod2.Text = ("Логин не может быть пустым.");
                    Lgn.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                    Errors++;
                }
                if (email.Length == 0)
                {
                    Vivod2.Text += ("Почта не может быть пустой.");
                    Eml.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                    Errors++;
                }
                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@(mail\.ru|gmail\.com|yandex\.ru)$"))
                {
                    Vivod2.Text += ("Пожалуйста, введите электронную почту в формате '123@mail.ru' и тому подобное.");
                    Eml.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                    Errors++;
                }
                if (pass.Length < 8)
                {
                    Vivod2.Text = ("Пароль не может быть меньше 8 символов.");
                    Psw.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                    Errors++;
                }
                break;
            }
            while (Errors != 0);

            if (Errors == 0)
            {
                var user = new User { Login = login, Email = email, Password = pass };
                var users = context.Users.FirstOrDefault(x => x.Login == login);
                if (users is not null)
                {
                    context.Users.Remove(users);
                    context.SaveChanges();
                }

                context.Users.Add(user);

                context.SaveChanges();
              
                Vivod2.Text = "Успешно изменено!";
            }

        }
       
    }
}
    

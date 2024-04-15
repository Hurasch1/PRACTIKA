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

namespace KomissarovPractika
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private List<char> _spesialSumb = new List<char>
        {
            '+','!','-','=',',','.','/',';',':','"','`','<','>','?','~','#'
        };
        private List<char> _Sobachka = new List<char>
        {
            '@'
        };

        public Window1()
        {
            InitializeComponent();
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            var login = Lgn.Text;

            var email = Eml.Text;

            var pass = Psw.Text;

            var password = Rpsw.Text;

            var context =  new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(X => X.Login == login && X.Email == email);
            if (user_exists is not null) 
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован");
                return;
            }
            if (!email.Any(x => _Sobachka.Contains(x)))
            {
                redline1.Visibility = Visibility.Visible;
                Vivod2.Text = ("Неккоректный email");
                return;
            }
            else
            {
                redline1.Visibility = Visibility.Hidden;
            }
            if (pass.Length < 5)
            {
                redline2.Visibility = Visibility.Visible;
                Vivod2.Text = ("Слишком короткий пароль");
                return;
            }
            else
            {
                redline2.Visibility = Visibility.Hidden;
            }
            if (!pass.Any(x => _spesialSumb.Contains(x)))
            {
                redline2.Visibility = Visibility.Visible;
                Vivod2.Text = ("Слишком легкий пароль, добавьте знаки (!,?,<,>)");
                return;
            }
            else
            {
                redline2.Visibility = Visibility.Hidden;
            }
            if (pass != password)
            {
                redline2.Visibility = Visibility.Visible;
                redline3.Visibility = Visibility.Visible;
                Vivod2.Text = ("Пароли не совподают");
                return;
            }
            else
            {
                redline2.Visibility = Visibility.Hidden;
                redline3.Visibility = Visibility.Hidden;
            }




            var user = new User { Login = login, Password = pass, Email = email };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Успешная регистрация");
            {
                MainWindow window = new();

                window.Show();
                Close();
            }


        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new();

            window.Show();
            Close();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}

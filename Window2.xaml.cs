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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string _login;
        public Window2(string login)
        {
            InitializeComponent();
            _login = login;

            Vivod.Text = "Здравстуйте," + " " + _login;
        }

        private void Cabinet_Click(object sender, RoutedEventArgs e)
        {
            Window3 window = new();

            window.Show();
            Close();
        }
    }
}

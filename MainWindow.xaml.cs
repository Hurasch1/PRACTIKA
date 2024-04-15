using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KomissarovPractika;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void regclick(object sender, RoutedEventArgs e)
    {
        Window1 window = new();

            window.Show();
            this.Hide();
    }


    int schet1 = 0;

    private async void vxod_Click(object sender, RoutedEventArgs e)
    {
        var login = lgn1.Text;

        var password = "";

        if (string.IsNullOrEmpty(psw1.Password))
        {
            password = txb1.Text;
        }
        else
        {
            password = psw1.Password;
        }


        var Oshibka = Oshibochka.Text;

        var context = new AppDbContext();

        var user = context.Users.SingleOrDefault(x => (x.Login == login || x.Email == login) && (x.Password == password || (x.Password == txb1.Text)));



        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
        {
            Oshibochka.Text = ("Логин и пароль обязательнях для заполнения");
            redline1.Visibility = Visibility.Visible;
            Redline.Visibility = Visibility.Visible;
            return;
        }

        if(user is null)
        {
            Oshibochka.Text = ("Введенные данные некорректны");
            redline1.Visibility = Visibility.Visible;
            Redline.Visibility = Visibility.Visible;
            schet1++;
            return;
        }
        if (schet1 == 3)
        {
            lgn1.IsEnabled = false;
            psw1.IsEnabled = false;
            txb1.IsEnabled = false;
            Oshibochka.Text = ("Вход заблокирован на 15 сек!");
            await Task.Delay(15000);
            lgn1.IsEnabled = true;
            psw1.IsEnabled = true;
            txb1.IsEnabled = false;
            schet1 = 0;
        }   
     
        Window2 window = new(user.Login);

        window.Show();
        Close();



    }
    bool schet = true;
    private void Passsee_Click(object sender, RoutedEventArgs e)
    {
        if (schet == true)
        {

            psw1.Visibility = Visibility.Visible;
            psw1.Password =  txb1.Text;
            txb1.Visibility = Visibility.Collapsed;
            Button button = (Button)sender;
            schet = false;

        }
        else
        {

            psw1.Visibility = Visibility.Collapsed;
            txb1.Text = psw1.Password;
            txb1.Visibility = Visibility.Visible;
            Button button = (Button)sender;
            schet = true;

        }
    }
}


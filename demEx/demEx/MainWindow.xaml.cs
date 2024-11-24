using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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

namespace demEx
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
        

        private int Autorization(string login, string password)
        {
            if(login != password)
            {
                return -1;
            }

            switch(login)
            {
                case "admin":
                    return 1;
                case "emp":
                    return 2;
                case "user":
                    return 3;
                default:
                    return -1;
            }
        }

        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            string login = loginEnter.Text;
            string password = passwordEnter.Password;
            int role = Autorization(login, password);

            switch(role)
            {
                case 1:
                    MessageBox.Show("admin");
                    break;
                case 2:
                    MessageBox.Show("emp");
                    break;
                case 3:
                    ClientOrderWindow clientOrderWindow = new ClientOrderWindow();
                    clientOrderWindow.Show();
                    this.Close();
                    break;
                case -1:
                    MessageBox.Show("ТЫ ЕБЛО", "ERORRR", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }
    }
}

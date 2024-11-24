using demEx.Models;
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

namespace demEx
{
    /// <summary>
    /// Логика взаимодействия для ClientOrderWindow.xaml
    /// </summary>
    public partial class ClientOrderWindow : Window
    {

        private string[] models = new Base().models;
        private string[] types = new Base().types;
        private string[] deffects = new Base().deffects;
        private string[] statuses = new Base().statuses;


        private List<Order> _order = new List<Order>();
        public ClientOrderWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                Order newOrder= new Order
                {
                    Id = i + 1,
                    Model = models[i % 4],
                    Type = types[i % 4],
                    Deffect = deffects[i % 4],
                    ClientName = "SHIPA",
                    Comment = "Почините микровалновку",
                    Status = statuses[i % 4]

                };

                _order.Add(newOrder);
            }
            dataGrid.ItemsSource = _order;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

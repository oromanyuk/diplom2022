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

namespace logistic
{
    /// <summary>
    /// Логика взаимодействия для ChoicePage.xaml
    /// </summary>
    public partial class ChoicePage : Page
    {
        public ChoicePage()
        {
            InitializeComponent();
        }

        private void Btn_Orders_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrdersPageAdm());
        }

        private void Btn_Drivers_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new DriversPageAdm());
        }

        private void Btn_Clients_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClientsPageAdm());
        }

        private void Btn_Transport_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TransportPageAdm());
        }
    }
}

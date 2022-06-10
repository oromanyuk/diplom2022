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
    /// Логика взаимодействия для OrdersPageAdm.xaml
    /// </summary>
    public partial class OrdersPageAdm : Page
    {
        public OrdersPageAdm()
        {
            InitializeComponent();
        }

        private void Btn_Edit_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageOrdersAdm((sender as Button).DataContext as orders));
        }

        private void Btn_Add_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageOrdersAdm(null));
        }

        private void AdmListVisible(object sender, DependencyPropertyChangedEventArgs e)
        {
            logisticEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridOrdersAdm.ItemsSource = logisticEntities2.GetContext().orders.ToList();
        }

        private void Btn_Del_Adm_Click(object sender, RoutedEventArgs e)
        {
            var polRemoving = DGridOrdersAdm.SelectedItems.Cast<orders>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {polRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    logisticEntities2.GetContext().orders.RemoveRange(polRemoving);
                    logisticEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridOrdersAdm.ItemsSource = logisticEntities2.GetContext().orders.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

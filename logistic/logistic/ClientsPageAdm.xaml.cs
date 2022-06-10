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
    /// Логика взаимодействия для ClientsPageAdm.xaml
    /// </summary>
    public partial class ClientsPageAdm : Page
    {
        public ClientsPageAdm()
        {
            InitializeComponent();
        }

        private void AdmList3Visible(object sender, DependencyPropertyChangedEventArgs e)
        {
            logisticEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridClientsAdm.ItemsSource = logisticEntities2.GetContext().clients.ToList();
        }

        private void Btn_Edit3_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageClientsAdm((sender as Button).DataContext as clients));
        }

        private void Btn_Add3_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageClientsAdm(null));
        }

        private void Btn_Del3_Adm_Click(object sender, RoutedEventArgs e)
        {
            var polRemoving = DGridClientsAdm.SelectedItems.Cast<clients>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {polRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    logisticEntities2.GetContext().clients.RemoveRange(polRemoving);
                    logisticEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridClientsAdm.ItemsSource = logisticEntities2.GetContext().clients.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

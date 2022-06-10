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
    /// Логика взаимодействия для TransportPageAdm.xaml
    /// </summary>
    public partial class TransportPageAdm : Page
    {
        public TransportPageAdm()
        {
            InitializeComponent();
        }

        private void AdmList4Visible(object sender, DependencyPropertyChangedEventArgs e)
        {
            logisticEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridTransportAdm.ItemsSource = logisticEntities2.GetContext().transport.ToList();
        }

        private void Btn_Edit4_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageTransportAdm((sender as Button).DataContext as transport));
        }

        private void Btn_Add4_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageTransportAdm(null));
        }

        private void Btn_Del4_Adm_Click(object sender, RoutedEventArgs e)
        {
            var polRemoving = DGridTransportAdm.SelectedItems.Cast<transport>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {polRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    logisticEntities2.GetContext().transport.RemoveRange(polRemoving);
                    logisticEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridTransportAdm.ItemsSource = logisticEntities2.GetContext().transport.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

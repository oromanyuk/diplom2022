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
    /// Логика взаимодействия для DriversPageAdm.xaml
    /// </summary>
    public partial class DriversPageAdm : Page
    {
        public DriversPageAdm()
        {
            InitializeComponent();
        }

        private void AdmList2Visible(object sender, DependencyPropertyChangedEventArgs e)
        {
            logisticEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGridDriversAdm.ItemsSource = logisticEntities2.GetContext().drivers.ToList();
        }

        private void Btn_Edit2_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageDriversAdm((sender as Button).DataContext as drivers));
        }

        private void Btn_Add2_Adm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPageDriversAdm(null));
        }

        private void Btn_Del2_Adm_Click(object sender, RoutedEventArgs e)
        {
            var polRemoving = DGridDriversAdm.SelectedItems.Cast<drivers>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {polRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    logisticEntities2.GetContext().drivers.RemoveRange(polRemoving);
                    logisticEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridDriversAdm.ItemsSource = logisticEntities2.GetContext().drivers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

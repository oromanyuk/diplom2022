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
    /// Логика взаимодействия для AddEditPageOrdersAdm.xaml
    /// </summary>
    public partial class AddEditPageOrdersAdm : Page
    {
        private orders _currentOrder = new orders();
        public AddEditPageOrdersAdm(orders selectedOrd)
        {
            InitializeComponent();
            if (selectedOrd != null)
                _currentOrder = selectedOrd;
            DataContext = _currentOrder;
            Combo_drivers_Adm.ItemsSource = logisticEntities2.GetContext().drivers.ToList();
            Combo_client_Adm.ItemsSource = logisticEntities2.GetContext().clients.ToList();
            Combo_transport_Adm.ItemsSource = logisticEntities2.GetContext().transport.ToList();
            Combo_status_adm.ItemsSource = logisticEntities2.GetContext().status_orders.ToList();
        }

        private void Btn_Save_Orders_Adm_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_currentOrder.drivers == null)
                errors.AppendLine("Выберите водителя");
            if (_currentOrder.clients == null)
                errors.AppendLine("Выберите клиента");
            if (_currentOrder.transport == null)
                errors.AppendLine("Выберите транспорт");
            if (string.IsNullOrEmpty(_currentOrder.cargo_size.ToString()))
                errors.AppendLine("Введите размер груза");
            if (string.IsNullOrEmpty(_currentOrder.lenght_path.ToString()))
                errors.AppendLine("Введите протяжённость пути");
            if (string.IsNullOrEmpty(_currentOrder.price.ToString()))
                errors.AppendLine("Введите цену");
            if (string.IsNullOrEmpty(_currentOrder.cargo_type.ToString()))
                errors.AppendLine("Введите тип груза");
            if (string.IsNullOrEmpty(_currentOrder.date.ToString()))
                errors.AppendLine("Введите дату поездки");
            if (_currentOrder.status_orders == null)
                errors.AppendLine("Выберите статус");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentOrder.id_order == 0)
                logisticEntities2.GetContext().orders.Add(_currentOrder);
            try
            {
                logisticEntities2.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");
                Manager.MainFrame.Navigate(new OrdersPageAdm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

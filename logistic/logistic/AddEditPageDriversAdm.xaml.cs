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
    /// Логика взаимодействия для AddEditPageDriversAdm.xaml
    /// </summary>
    public partial class AddEditPageDriversAdm : Page
    {
        private drivers _currentDrivers = new drivers();
        public AddEditPageDriversAdm(drivers selectedDri)
        {
            InitializeComponent();
            if (selectedDri != null)
                _currentDrivers = selectedDri;
            DataContext = _currentDrivers;
        }

        private void Btn_Save_Drivers_Adm_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(_currentDrivers.FIO.ToString()))
                errors.AppendLine("Введите ФИО водителя");
            if (string.IsNullOrEmpty(_currentDrivers.experience.ToString()))
                errors.AppendLine("Введите водительский стаж водителя");
            if (string.IsNullOrEmpty(_currentDrivers.telephone.ToString()))
                errors.AppendLine("Введите телефон водителя");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentDrivers.id_drivers == 0)
                logisticEntities2.GetContext().drivers.Add(_currentDrivers);
            try
            {
                logisticEntities2.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");
                Manager.MainFrame.Navigate(new DriversPageAdm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

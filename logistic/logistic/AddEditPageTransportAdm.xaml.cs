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
    /// Логика взаимодействия для AddEditPageTransportAdm.xaml
    /// </summary>
    public partial class AddEditPageTransportAdm : Page
    {
        private transport _currentTransport = new transport();
        public AddEditPageTransportAdm(transport selectedTra)
        {
            InitializeComponent();
            if (selectedTra != null)
                _currentTransport = selectedTra;
            DataContext = _currentTransport;
        }

        private void Btn_Save_Transport_Adm_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(_currentTransport.brand.ToString()))
                errors.AppendLine("Введите бренд автомобиля");
            if (string.IsNullOrEmpty(_currentTransport.reg_number.ToString()))
                errors.AppendLine("Введите регистрационный номер");
            if (string.IsNullOrEmpty(_currentTransport.capacity.ToString()))
                errors.AppendLine("Введите грузоподъёмность");
            if (string.IsNullOrEmpty(_currentTransport.mileage.ToString()))
                errors.AppendLine("Введите пробег");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentTransport.id_transport == 0)
                logisticEntities2.GetContext().transport.Add(_currentTransport);
            try
            {
                logisticEntities2.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");
                Manager.MainFrame.Navigate(new TransportPageAdm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

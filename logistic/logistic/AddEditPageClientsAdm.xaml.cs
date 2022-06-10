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
    /// Логика взаимодействия для AddEditPageClientsAdm.xaml
    /// </summary>
    public partial class AddEditPageClientsAdm : Page
    {
        private clients _currentClients = new clients();
        public AddEditPageClientsAdm(clients selectedCli)
        {
            InitializeComponent();
            if (selectedCli != null)
                _currentClients = selectedCli;
            DataContext = _currentClients;
        }

        private void Btn_Save_Clients_Adm_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(_currentClients.FIO.ToString()))
                errors.AppendLine("Введите ФИО клиента");
            if (string.IsNullOrEmpty(_currentClients.telephone.ToString()))
                errors.AppendLine("Введите телефон телефон");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClients.id_client == 0)
                logisticEntities2.GetContext().clients.Add(_currentClients);
            try
            {
                logisticEntities2.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");
                Manager.MainFrame.Navigate(new ClientsPageAdm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

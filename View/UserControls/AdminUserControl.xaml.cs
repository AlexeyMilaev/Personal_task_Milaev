using personal_task_Milaev.Core;
using personal_task_Milaev.Model;
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

namespace personal_task_Milaev.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для AdminUserControl.xaml
    /// </summary>
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
            DataRequestInfo.ItemsSource = FrameNavigate.DB.Requests.OrderBy(u => u.User.UserFIO).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idRequest = (DataRequestInfo.SelectedItem as Request).RequestID;

            var result = MessageBox.Show("Хотите отменить запрос?",
                                        "Системное сообщение",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Request request = (from u in FrameNavigate.DB.Requests where u.RequestID == idRequest select u).SingleOrDefault();
                FrameNavigate.DB.Requests.Remove(request);
                FrameNavigate.DB.SaveChanges();
                DataRequestInfo.ItemsSource = FrameNavigate.DB.Requests.OrderBy(u => u.RequestID).ToList();
            }    
            

        } 
    }
}

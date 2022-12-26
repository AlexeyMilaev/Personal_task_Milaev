using personal_task_Milaev.Core;

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

namespace personal_task_Milaev.View
{
    /// <summary>
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
            
        }

        private async void request1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrameNavigate.DB.Requests.Add(new Model.Request
                {
                    UserID = Authorization.AuthorizedUser.UserID,
                    InsuranceID = 1
                });

                await FrameNavigate.DB.SaveChangesAsync();

                MessageBox.Show("Запрос отправлен на рассмотрение", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void request2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrameNavigate.DB.Requests.Add(new Model.Request
                {
                    UserID = Authorization.AuthorizedUser.UserID,
                    InsuranceID = 2
                });

                await FrameNavigate.DB.SaveChangesAsync();

                MessageBox.Show("Запрос отправлен на рассмотрение", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void request3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrameNavigate.DB.Requests.Add(new Model.Request
                {
                    UserID = Authorization.AuthorizedUser.UserID,
                    InsuranceID = 3
                });

                await FrameNavigate.DB.SaveChangesAsync();

                MessageBox.Show("Запрос отправлен на рассмотрение", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainPage());
        }
    }
}

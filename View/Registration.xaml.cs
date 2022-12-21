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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(fio.Text) || string.IsNullOrEmpty(telephone.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Password))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                FrameNavigate.DB.Users.Add(new Model.User
                {   
                    UserFIO = fio.Text,
                    UserPhone = telephone.Text,
                    UserEmail = email.Text,
                    UserPassword = password.Password,
                    RoleID = 2
                });

                await FrameNavigate.DB.SaveChangesAsync();
                MessageBox.Show("Учетная запись создана!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                FrameNavigate.FrameObject.Navigate(new Login());
            }
        }
    }
}

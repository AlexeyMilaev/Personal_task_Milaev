using personal_task_Milaev.Core;
using personal_task_Milaev.Model;
using personal_task_Milaev.View;
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
using System.Windows.Shapes;

namespace personal_task_Milaev.View
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();


        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User userModel = FrameNavigate.DB.Users.FirstOrDefault(u => u.UserEmail == TbLogin.Text && u.UserPassword == PsbPassword.Password);
                if (userModel == null)
                {
                    MessageBox.Show("Ошибка данных",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    Authorization.AuthorizedUser = userModel;
                    switch (userModel.RoleID)
                    {
                        case 1:
                            FrameNavigate.FrameObject.Navigate(new Administrator());
                            break;
                        case 2:
                            FrameNavigate.FrameObject.Navigate(new UserPage());
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системная ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new Registration());
        }
    }
}

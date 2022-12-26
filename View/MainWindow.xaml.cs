using personal_task_Milaev.Core;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace personal_task_Milaev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            FrameNavigate.FrameObject = MainWindowFrame;
            FrameNavigate.FrameObject.Navigate(new MainPage());

            FrameNavigate.DB = new Model.dbEntities3();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new Login());
        }


        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new Help());
        }

        private void OfficesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Navigate(new Offices());
        }


    }
}

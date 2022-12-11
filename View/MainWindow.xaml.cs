using personal_task_Milaev.Core;
using personal_task_Milaev.View;
using personal_task_Milaev.View.Pages.LoginPage;
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
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void comeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            help win = new help();
            win.Owner = this;
            win.Show();
        }

        private void OfficesBtn_Click(object sender, RoutedEventArgs e)
        {
            Offices win = new Offices();
            win.Owner = this;
            win.Show();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Close();



        }

    }
}

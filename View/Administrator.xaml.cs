using personal_task_Milaev.View.UserControls;
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
    /// Логика взаимодействия для Administrator.xaml
    /// </summary>
    public partial class Administrator : Page
    {
        public Administrator()
        {
            InitializeComponent();
        }


        private void MenuRequests_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminUserControl());
        }
    }
}

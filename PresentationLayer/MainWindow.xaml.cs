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
using PresentationLayer.ServiceReference1;

namespace PresentationLayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TeacherServiceClient proxy = new TeacherServiceClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            proxy.AddTeacherAsync(new TeacherDTO
            {
                Login = tbLogin.Text,
                Password = tbPass.Text,
                Name = tbName.Text
            });
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var teachers = await proxy.GetTeachersAsync();
            listbox.ItemsSource = teachers.ToList();
            listbox.DisplayMemberPath = "Name";

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            proxy.DeleteTeacher((TeacherDTO)listbox.SelectedValue);
        }
    }
}

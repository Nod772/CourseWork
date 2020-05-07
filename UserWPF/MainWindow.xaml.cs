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

namespace UserWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(Teacher_btn.IsChecked==true)
            {

            }
            else
            {
                if(Log_txt.Text!="")
                {
                    LoginWindow.Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("You must enter name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            User_btn.Visibility = Visibility.Collapsed;
            Teacher_btn.Visibility = Visibility.Collapsed;

        }

        private void Teacher_CLick(object sender, RoutedEventArgs e)
        {
            if (LoginTeacherWindow.Visibility == Visibility.Collapsed)
                LoginTeacherWindow.Visibility = Visibility.Visible;
            LogText.Text = "Login";
        }

        private void User_CLick(object sender, RoutedEventArgs e)
        {
            LoginTeacherWindow.Visibility = Visibility.Collapsed;
            LogText.Text = "Enter Name";
            
        }
    }
}

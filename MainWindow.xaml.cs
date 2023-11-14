using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Windows_Authentication
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
        string username1 = "Admin";
        string password1 = "123456";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Authentication successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            if (username == null || password == null)
            {
                return false;
            }
            else
            {
                if (username1 == username && password1 == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
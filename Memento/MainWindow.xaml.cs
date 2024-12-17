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

namespace Memento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User _user;
        public MainWindow()
        {
            InitializeComponent();
            _user = new User("Иван", "Ivan@mail.com");
            LoadUserData();
        }

        private void LoadUserData()
        {
            LoginTextBox.Text = _user.Login;
            EmailTextBox.Text = _user.Email;
            ThemeComboBox.SelectedIndex = _user.Theme == Theme.Light ? 0 : 1;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _user.Login = LoginTextBox.Text;
            _user.Email = EmailTextBox.Text;
            _user.Theme = ThemeComboBox.SelectedIndex == 0 ? Theme.Light : Theme.Dark;
            _user.SaveState();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            _user.LoadState();
            LoadUserData();
        }
    }
}
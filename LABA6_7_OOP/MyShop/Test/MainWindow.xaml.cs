using System.Windows;
using System.Windows.Input;

namespace Test
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

        private void EscButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        } // close the LogIn Window

        private void HideButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }// Hide the LogIn Window

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void LogoContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (tb2.Password.Length > 0)
            {
                watermark.Visibility = Visibility.Collapsed;
            }
            else
            {
                watermark.Visibility = Visibility.Visible;
            }
        }
    }
}

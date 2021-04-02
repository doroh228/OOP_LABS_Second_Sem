using System.Windows;
using Main_Administrait.ViewModuls;

namespace Main_Administrait
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModuls();
        }
    }
}

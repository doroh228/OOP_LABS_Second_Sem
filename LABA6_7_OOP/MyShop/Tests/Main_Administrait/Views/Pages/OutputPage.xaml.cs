using Main_Administrait.ViewModuls.ViewModulsPages;
using System.Windows.Controls;


namespace Main_Administrait.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для OutputPage.xaml
    /// </summary>
    public partial class OutputPage : Page
    {
        public OutputPage()
        {
            InitializeComponent();
            DataContext = new OutputViewModel();
        }
    }
}

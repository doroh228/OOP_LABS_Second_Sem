using Main_Administrait.ViewModuls.ViewModulsPages;
using System;
using System.Windows.Controls;

namespace Main_Administrait.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            DataContext = new RegistrationViewModul();
        }
    }
}

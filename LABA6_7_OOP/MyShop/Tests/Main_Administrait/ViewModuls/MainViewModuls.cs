using GalaSoft.MvvmLight.Command;
using Main_Administrait.Views.Pages;
using System.Windows.Controls;
using System.Windows.Input;

namespace Main_Administrait.ViewModuls
{
    class MainViewModuls : ViewModuls.Base.ViewModuls
    {
        private Page Welcome;
        private Page GoodBye;
        private Page _currentPage;

        public Page CurrentPage
        {
            get => _currentPage;
            set => Set(ref _currentPage, value);
        }

        public MainViewModuls()
        {
            Welcome = new RegistrationPage();
            GoodBye = new OutputPage();
            CurrentPage = Welcome;
        }

        public ICommand bRegister_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = Welcome);
            }
        }
        public ICommand bOutput_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = GoodBye);
            }
        }
    }
}

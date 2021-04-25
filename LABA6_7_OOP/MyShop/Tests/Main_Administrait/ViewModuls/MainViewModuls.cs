using GalaSoft.MvvmLight.Command;
using Main_Administrait.Views.Pages;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Main_Administrait.ViewModuls
{
    class MainViewModuls : ViewModuls.Base.ViewModuls
    {
        private List<string> _menuLanguage;
        private Page Welcome;
        private Page GoodBye;
        private Page _currentPage;
        private double _frameOpacity;
        public double FrameOpacity
        {
            get
            {
                return _frameOpacity;
            }
            private set
            {
                Set(ref _frameOpacity, value);
            }
        }

        public List<string> MenuLanguage
        {
            get => _menuLanguage;
            set => Set(ref _menuLanguage, value);
        }

        public Page CurrentPage
        {
            get => _currentPage;
            set => Set(ref _currentPage, value);
        }

        public MainViewModuls()
        {
            FrameOpacity = 1;
            Welcome = new RegistrationPage();
            GoodBye = new OutputPage();
            CurrentPage = Welcome;
        }

        public ICommand bRegister_Click
        {
            get
            {
                return new RelayCommand(() => ChangePage(Welcome));
            }
        }
        public ICommand bOutput_Click
        {
            get
            {
                return new RelayCommand(() => ChangePage(GoodBye));
            }
        }

        async private void ChangePage(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1; i > 0.0; i -= 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(30);
                }
                CurrentPage = page;
                for (double i = 0.0; i <= 1; i += 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(30);
                }
            });
        }
    }
}

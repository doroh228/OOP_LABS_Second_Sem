using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Main_Administrait.ViewModuls.ViewModulsPages
{
    class RegistrationViewModul : Base.ViewModuls
    {
        private string _visability;
        private string _currentImage;
        private string _visabilityPancil;

        public string CurrentImage
        {
            get => _currentImage;
            set => Set(ref _currentImage, value);
        } 
        public string Visibility
        {
            get => _visability;
            set => Set(ref _visability, value);
        }
        public string ViisabilityPancil
        {
            get => _visabilityPancil;
            set => Set(ref _visabilityPancil, value);
        }

        public RegistrationViewModul()
        {
            ViisabilityPancil = "Hidden";
            Visibility = "Visible";
        }

        public ICommand ChangeVisibilityH
        {
            get
            {
                
                return new RelayCommand(()=> {
                    Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                    dlg.FileName = ""; // Default file name
                    dlg.DefaultExt = ".png"; // Default file extension
                                             //    dlg.Filter = "Pictures (.png,jpg)|*.png,*.jpg"; // Filter files by extension

                    // Show open file dialog box
                    Nullable<bool> result = dlg.ShowDialog();

                    // Process open file dialog box results
                    if (result == true)
                    {
                        // Open document
                        BitmapImage image = new BitmapImage();
                        image.BeginInit();
                        image.UriSource = new Uri(dlg.FileName);
                        CurrentImage = dlg.FileName;
                        image.EndInit();
                    }

                    Visibility = "Hidden";
                    ViisabilityPancil = "Visible";
                });
            }
        }
    }
}

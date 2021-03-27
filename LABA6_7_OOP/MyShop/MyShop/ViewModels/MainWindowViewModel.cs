
namespace MyShop.ViewModels.Base
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title of Window
        private string _Title = "Taxi-LR";

        /// <summary>Title Window</summary>
        public string Title
        {
            get => _Title;
            //set
            //{
            //    if (Equals(_Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();
            //}
            set => Set(ref _Title, value);
        }
        #endregion
    }
}

using System.Collections.Generic;
using Main_Administrait.Models;
using Main_Administrait.Views;
using Main_Administrait.Helpers;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using Main_Administrait.Views.EditInfo;
using System.Linq;

namespace Main_Administrait.ViewModuls.ViewModulsPages
{
    public class OutputViewModel : Main_Administrait.ViewModuls.Base.ViewModuls
    {
        private Car _selectedCar;
        private List<Car> _cars; 
        public List<Car> Cars
        {
            get => _cars;
            set => Set(ref _cars, value);
        }
        public OutputViewModel()
        {
            Cars = new List<Car>();
            Cars = SerializeInfo.Deserialize<List<Car>>("test.xml");
        }
        public Car SelectedCar
        {
            get => _selectedCar;
            set => Set(ref _selectedCar,value);
        }

        public ICommand RefrashCarsCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Cars = SerializeInfo.Deserialize<List<Car>>("test.xml");
                });
            }
            
        }

        
        public ICommand EditCarCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (SelectedCar != null)
                    {
                        EditCar editCarWindow = new EditCar(SelectedCar);
                        editCarWindow.Show();
                    }
                });
            }
        }

        public ICommand DeleteCarCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (Cars.Count >= 1)
                    {
                        Cars.RemoveAll(t => t.VinNumber == SelectedCar.VinNumber);
                        SerializeInfo.Serialize<List<Car>>(Cars, "test.xml");
                        MessageBox.Show("delete succesfull");
                    }
                });
            }
        }
    }
}

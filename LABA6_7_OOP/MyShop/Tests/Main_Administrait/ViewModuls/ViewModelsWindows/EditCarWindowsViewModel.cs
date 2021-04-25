using System;
using System.Collections.Generic;
using Main_Administrait.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main_Administrait.ViewModuls;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Windows;
using Main_Administrait.Helpers;

namespace Main_Administrait.ViewModuls.ViewModelsWindows
{
    class EditCarWindowsViewModel : Base.ViewModuls
    {

        #region Properties
        private Car _currentCar;
        private List<Car> _cars = new List<Car>();
        private string _pathToPicture;
        private string _vinNumber;
        private string _colorOfCar;
        private string _numberPlate;
        private string _brand;
        private string _classOfCar = string.Empty;
        private string _notes;

        /// <summary>
        /// collection cars
        /// </summary>
        public List<Car> Cars
        {
            get => _cars;
            set => Set(ref _cars, value);
        }
        /// <summary>
        /// Path to car picture
        /// </summary>
        public string PathToPicture
        {
            get => _pathToPicture;
            set => Set(ref _pathToPicture, value);
        }

        /// <summary>
        /// Brand of Car
        /// </summary>
        public string Brand
        {
            get => _brand;
            set => Set(ref _brand, value);
        }

        /// <summary>
        /// Class of car
        /// </summary>
        public string ClassOfCar
        {
            get => _classOfCar;
            set => Set(ref _classOfCar, value);
        }

        /// <summary>
        /// Number of Car
        /// </summary>
        public string NumberPlate
        {
            get => _numberPlate;
            set => Set(ref _numberPlate, value);
        }

        /// <summary>
        /// Color of Car
        /// </summary>
        public string ColorOfCar
        {
            get => _colorOfCar;
            set => Set(ref _colorOfCar, value);
        }

        /// <summary>
        /// VIN number of Car
        /// </summary>
        public string VinNumber
        {
            get => _vinNumber;
            set => Set(ref _vinNumber, value);
        }

        /// <summary>
        /// notes about car
        /// </summary>
        public string Notes
        {
            get => _notes;
            set => Set(ref _notes, value);
        }

        #region Image
        private string _visability;
        private string _visabilityPancil;


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

        #endregion

        #endregion

        public EditCarWindowsViewModel(Car car)
        {
            PathToPicture = car.PathToPicture;
            Brand = car.Brand;
            ClassOfCar = car.ClassOfCar;
            NumberPlate = car.NumberPlate;
            ColorOfCar = car.ColorOfCar;
            VinNumber = car.VinNumber;
            Notes = car.Notes;
            ViisabilityPancil = "Visible";
            Visibility = "Hidden";
            Cars = SerializeInfo.Deserialize<List<Car>>("test.xml");
            _currentCar = car;
        }
        public EditCarWindowsViewModel()
        {
        }

        #region ICommands

        #region Image

        public ICommand ChangeVisibilityH
        {
            get
            {

                return new RelayCommand(() =>
                {
                    Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                    dlg.FileName = ""; // Default file name
                    dlg.DefaultExt = ".png"; // Default file extension

                    // Show open file dialog box
                    Nullable<bool> result = dlg.ShowDialog();

                    // Process open file dialog box results
                    if (result == true)
                    {
                        // Open document
                        if (!string.IsNullOrEmpty(dlg.FileName))
                        {
                            PathToPicture = dlg.FileName;
                        }
                        Visibility = "Hidden";
                        ViisabilityPancil = "Visible";
                    }
                });
            }
        }

        #endregion

        public ICommand ClearingBut
        {
            get
            {
                return new RelayCommand(() =>
                {
                    PathToPicture = string.Empty;
                    Brand = string.Empty;
                    ClassOfCar = string.Empty;
                    NumberPlate = string.Empty;
                    ColorOfCar = string.Empty;
                    VinNumber = string.Empty;
                    Notes = string.Empty;
                    ViisabilityPancil = "Hidden";
                    Visibility = "Visible";
                });
            }
        }


        public ICommand SavengBut
        {
            get
            {
                return new RelayCommand(() =>
                {

                    if (string.IsNullOrEmpty(VinNumber) || string.IsNullOrEmpty(Notes) || string.IsNullOrEmpty(ClassOfCar) || string.IsNullOrEmpty(PathToPicture))
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                    else
                    {
                        bool contien = false;
                        Car _car = new Car(PathToPicture, Brand, ClassOfCar, NumberPlate, ColorOfCar, VinNumber, Notes);
                        foreach (var car in Cars)
                        {
                            if (_car.VinNumber == _currentCar.VinNumber || _car.VinNumber != car.VinNumber)
                            {
                                contien = true;
                            }
                            else
                            {
                                MessageBox.Show("Машина с таким VIN-номером уже есть");
                            }
                        }
                        if (contien)
                        {
                            foreach (var car in Cars)
                            {
                            if (_currentCar.VinNumber == car.VinNumber)
                                {
                                    car.VinNumber = _car.VinNumber;
                                    car.PathToPicture = _car.PathToPicture;
                                    car.Brand = _car.Brand;
                                    car.ClassOfCar = _car.ClassOfCar;
                                    car.ColorOfCar = _car.ColorOfCar;
                                    car.NumberPlate = _car.NumberPlate;
                                    car.Notes = _car.Notes;
                                }
                            }
                            SerializeInfo.Serialize<List<Car>>(Cars, "test.xml");
                            MessageBox.Show("Edited seccsesfull");
                            
                            #region Clearing

                            PathToPicture = string.Empty;
                            Brand = string.Empty;
                            ClassOfCar = string.Empty;
                            NumberPlate = string.Empty;
                            ColorOfCar = string.Empty;
                            VinNumber = string.Empty;
                            Notes = string.Empty;
                            ViisabilityPancil = "Hidden";
                            Visibility = "Visible";
                        }

                        #endregion
                    }
                });
            }
        }
        #endregion
    }
}

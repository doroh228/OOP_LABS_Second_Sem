using System;
using System.Xml.Serialization;
using Main_Administrait;

namespace Main_Administrait.Models
{
    [Serializable]
    [XmlRoot(Namespace = "LABA_6")]
    [XmlType("Car")]
    public class Car : ViewModuls.Base.ViewModuls
    {
        #region MyRegion Fields
        [NonSerialized]
        private string _pathToPicture;
        [NonSerialized]
        private string _vinNumber;
        [NonSerialized]
        private string _colorOfCar;
        [NonSerialized]
        private string _numberPlate;
        [NonSerialized]
        private string _brand;
        [NonSerialized]
        private string _classOfCar;
        [NonSerialized]
        private string _notes;

        #region Properties
        [XmlElement(ElementName = "PathToPicture")]
        /// <summary>
        /// Path to car picture
        /// </summary>
        public string PathToPicture
        {
            get => _pathToPicture;
            set => Set(ref _pathToPicture, value);
        }

        [XmlElement(ElementName = "Brand")]
        /// <summary>
        /// Brand of Car
        /// </summary>
        public string Brand
        {
            get => _brand;
            set => Set(ref _brand, value);
        }

        [XmlElement(ElementName = "ClassOfCar")]
        /// <summary>
        /// Class of car
        /// </summary>
        public string ClassOfCar
        {
            get => _classOfCar;
            set => Set(ref _classOfCar, value);
        }

        [XmlElement(ElementName = "NumberPlate")]
        /// <summary>
        /// Number of Car
        /// </summary>
        public string NumberPlate
        {
            get => _numberPlate;
            set => Set(ref _numberPlate, value);
        }

        [XmlElement(ElementName = "ColorOfCar")]
        /// <summary>
        /// Color of Car
        /// </summary>
        public string ColorOfCar
        {
            get => _colorOfCar;
            set => Set(ref _colorOfCar, value);
        }

        [XmlElement(ElementName = "VinNumber")]
        /// <summary>
        /// VIN number of Car
        /// </summary>
        public string VinNumber
        {
            get => _vinNumber;
            set => Set(ref _vinNumber, value);
        }
        /// <summary>
        /// Notes about Car
        /// </summary>
        public string Notes
        {
            get => _notes;
            set => Set(ref _notes, value);
        }

        #endregion

        #endregion

        /// <summary>
        /// create new Car
        /// </summary>
        /// <param name="pathToPicture"> Path to car picture</param>
        /// <param name="vinNumber">VIN number of car</param>
        /// <param name="colorOfCar">Color of Car</param>
        /// <param name="numberPlate">Numberplate of car</param>
        /// <param name="brand">Car brand</param>
        /// <param name="classOfCar">Class of car</param>
        public Car(string pathToPicture, string brand, string classOfCar, string numberPlate, string colorOfCar, string vinNumber, string notes)
        {
            PathToPicture = pathToPicture;
            Brand = brand;
            ClassOfCar = classOfCar;
            NumberPlate = numberPlate;
            ColorOfCar = colorOfCar;
            VinNumber = vinNumber;
            Notes = notes;
        }
        public Car(){}
    }
}

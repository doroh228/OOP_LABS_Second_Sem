using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MyShopConsole
{
    public class Program
    {
        static void Main()
        {
            List<Car> _cars = new List<Car>();
            Car car;
            string _pathToPicture;
            string _vinNumber;
            string _colorOfCar;
            string _numberPlate;
            string _brand;
            string _classOfCar = string.Empty;
            string _notes;
            Console.WriteLine($"pathToPick ");
            _pathToPicture =  Console.ReadLine();

            Console.WriteLine($"_vinNumber ");
            _vinNumber = Console.ReadLine();

            Console.WriteLine($"_colorOfCar ");
            _colorOfCar = Console.ReadLine();

            Console.WriteLine($"_numberPlate ");
            _numberPlate = Console.ReadLine();

            Console.WriteLine($"_brand ");
            _brand = Console.ReadLine();

            Console.WriteLine($"_classOfCar ");
            _classOfCar = Console.ReadLine();

            Console.WriteLine($"_notes ");
            _notes = Console.ReadLine();

            car = new Car(_pathToPicture, _brand, _classOfCar, _numberPlate, _colorOfCar, _vinNumber, _notes);
            Console.WriteLine($"{car.Brand}");
            _cars.Add(car);

            foreach (var item in _cars)
            {
                Console.WriteLine($"{item.Brand}");
            }
            SerializeInfo.Serialize<List<Car>>(_cars, "test.xml");
            _cars = SerializeInfo.Deserialize<List<Car>>("test.xml");
            foreach (var item in _cars)
            {
                Console.WriteLine($"{item.Brand}");
            }
        }


        [Serializable]
        [XmlRoot(Namespace = "LABA_6")]
        [XmlType("Car")]
        public class Car
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
                set => _pathToPicture = value;
            }

            [XmlElement(ElementName = "Brand")]
            /// <summary>
            /// Brand of Car
            /// </summary>
            public string Brand
            {
                get => _brand;
                set => _brand = value;
            }

            [XmlElement(ElementName = "ClassOfCar")]
            /// <summary>
            /// Class of car
            /// </summary>
            public string ClassOfCar
            {
                get => _classOfCar;
                set => _classOfCar = value;
            }

            [XmlElement(ElementName = "NumberPlate")]
            /// <summary>
            /// Number of Car
            /// </summary>
            public string NumberPlate
            {
                get => _numberPlate;
                set => _numberPlate = value;
            }

            [XmlElement(ElementName = "ColorOfCar")]
            /// <summary>
            /// Color of Car
            /// </summary>
            public string ColorOfCar
            {
                get => _colorOfCar;
                set => _colorOfCar = value;
            }

            [XmlElement(ElementName = "VinNumber")]
            /// <summary>
            /// VIN number of Car
            /// </summary>
            public string VinNumber
            {
                get => _vinNumber;
                set => _vinNumber = value;
            }
            /// <summary>
            /// Notes about Car
            /// </summary>
            public string Notes
            {
                get => _notes;
                set => _notes = value;
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
            public Car() { }
        }

        class SerializeInfo
        {
            public static void Serialize<T>(T obj, string filename)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    formatter.Serialize(fs, obj);
                }
            }
            public static T Deserialize<T>(string filename)
            {
                T obj;
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(T));
                    obj = (T)formatter.Deserialize(fs);
                }
                return obj;
            }
        }
    }
}

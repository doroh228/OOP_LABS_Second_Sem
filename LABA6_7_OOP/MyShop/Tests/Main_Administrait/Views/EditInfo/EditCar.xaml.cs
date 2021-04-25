using Main_Administrait.Models;
using Main_Administrait.ViewModuls.ViewModelsWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Main_Administrait.Views.EditInfo
{
    /// <summary>
    /// Логика взаимодействия для EditCar.xaml
    /// </summary>
    public partial class EditCar : Window
    {
        public EditCar()
        {
            InitializeComponent();
        }
        public EditCar(Car car)
        {
            InitializeComponent();
            DataContext = new EditCarWindowsViewModel(car);
        }
    }
}

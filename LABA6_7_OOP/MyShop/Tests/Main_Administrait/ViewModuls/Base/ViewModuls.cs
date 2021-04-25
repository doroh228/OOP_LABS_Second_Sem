using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Main_Administrait.ViewModuls.Base
{
    public abstract class ViewModuls : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)// Мы можем вызывать не указывая в параметр имя свойства
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)//[referance, new value, propertyName]- разрешает менять дургие свойства при смене одного из свойств
        {
            if (Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}

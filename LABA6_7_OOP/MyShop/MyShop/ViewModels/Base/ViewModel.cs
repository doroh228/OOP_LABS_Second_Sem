using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyShop.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
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

        //~ViewModel()
        //{
        //    Dispose(false);
        //}it's a for example

        public void Dispose()
        {
            Dispose(true);
        }

        private bool _Dispossed;

        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Dispossed) return;
            _Dispossed = true; // Освобождение управляемых ресурсов
        }
    }
}

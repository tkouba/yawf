using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace yawf.ViewModels
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        protected void SetValue<T>(ref T holder, T value, [CallerMemberName] string name = "")
        {
            holder = value;
            OnPropertyChanged(name);
        }

    }
}

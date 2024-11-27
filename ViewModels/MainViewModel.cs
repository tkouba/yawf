using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace yawf.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private bool _isBusy;
        private double _latitude;
        private double _longitude;


        public bool IsBusy
        {
            get => _isBusy;
            set => SetValue(ref _isBusy, value);
        }

        public double Latitude
        {
            get => _latitude;
            set => SetValue(ref _latitude, value);
        }

        public double Longitude
        {
            get => _longitude;
            set => SetValue(ref _longitude, value);
        }

        public ICommand RefreshCommand { get; private set; }

        public MainViewModel()
        {
            RefreshCommand = new Command(async () => await Refresh());
        }
        async Task Refresh()
        {
            try
            {
                if (!IsBusy)
                    IsBusy = true;
                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                Location? location = await Geolocation.Default.GetLocationAsync(request, CancellationToken.None);
                Latitude = location?.Latitude ?? 0;
                Longitude = location?.Longitude ?? 0;
            }
            catch (Exception ex)
            {
                Latitude = Longitude = 0;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

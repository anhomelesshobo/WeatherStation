using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        /// 
        public ITemperatureService TemperatureService;

        public DelegateCommand<string> GetTempCommand { get; set; }

        public Object CurrentTemp { get; set; }

        public TemperatureViewModel()
        {
            GetTempCommand = new DelegateCommand<string>(GetTempData);
        }

        private void GetTempData(string obj)
        {
            CurrentTemp = TemperatureService.GetTempAsync();
        }

        public void SetTemperatureService(ITemperatureService IT)
        {
            TemperatureService = IT;
        }

        public double CelsiusinFahrenheit(double c)
        {
            return c * (9.0f / 5.0f) + 32;
        }

        public double FahrenheitinCelsius(double f)
        {
            return (f - 32) * 5.0f / 9.0f;
        }

        public bool CanGetTemp()
        {
            if(TemperatureService == null)
            {
                return false;
            }
           
            return true;
          
            
        }
    }
}

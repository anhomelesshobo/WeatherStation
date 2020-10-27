using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        /// 
        public DelegateCommand<string> GetTempCommand { get; }

        

        public double CelsiusinFahrenheit(double c)
        {
            return c * (9.0f / 5.0f) + 32;
        }

        public double FahrenheitinCelsius(double f)
        {
            return (f - 32) * 5.0f / 9.0f;
        }
    }
}

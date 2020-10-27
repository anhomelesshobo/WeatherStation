using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        public double CelsiusinFahrenheit(double c)
        {
            return c * (9.0f / 5.0f) + 32;
        }
    }
}

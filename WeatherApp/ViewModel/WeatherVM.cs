using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model.Classes;
using WeatherApp.ViewModel.Helpers;

namespace WeatherApp.ViewModel
{
    public class WeatherVM : INotifyPropertyChanged
    {
        private City selectedCity;
        public City SelectedCity
        {
            get { return selectedCity; }
            set
            {
                selectedCity = value;

                UpdateCurrentCondition(value.Key);
            }
        }

        private CurrentCondition currentConditionVille;
        public CurrentCondition CurrentConditionVille
        {
            get { return currentConditionVille; }
            set
            {
                currentConditionVille = value;
                OnPropertyChanged("CurrentConditionVille");

            }
        }

        private string query;
        public string Query { 
            get { return query; } 
            set 
            { 
                query = value;
                //on trigger l'event a chaque changement
                OnPropertyChanged("query");

                //les elements abonnés a l'event seront maj

                //ObservableCollection<City> l = new ObservableCollection<City>();
                //l.Add(new City(
                //        1, "132608", "City", 41, "Orléans",
                //        new Country("FR", "France"),
                //        new AdministrativeArea("45", "Loiret")
                //    )
                //);

                //this.Cities = l;
                UpdateCities(value);
            } 
        }


        private List<City> cities;
        public List<City> Cities
        {
            get { return cities; }
            set
            {
                cities = value;
                //on trigger l'event a chaque changement
                OnPropertyChanged("Cities");

                //les elements abonnés a l'event seront maj
            }
        }


        private CurrentCondition currentCondition;
        public CurrentCondition CurrentCondition
        {
            get { return currentCondition; }
            set
            {
                currentCondition = value;
                //on trigger l'event a chaque changement
                OnPropertyChanged("CurrentCondition");

                //les elements abonnés a l'event seront maj
            }
        }

        public WeatherVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //ON appelle pour CHAQUE changement
        private void OnPropertyChanged(string propertyName)
        {
            //Si propertyChanged existe, in invoque l'event
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void UpdateCities(string v)
        {

            this.Cities = await AccuWeatherHelper.GetCities(v);

        }

        private async void UpdateCurrentCondition(string v)
        {

            this.CurrentConditionVille = await AccuWeatherHelper.GetCurrentConditions(v);

        }
    }
}

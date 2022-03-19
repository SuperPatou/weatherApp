using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.Classes
{
    public class City
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public Country Country { get; set; }
        public AdministrativeArea AdministrativeArea { get; set; }

        public City(int version, string key, string type, int rank, string localizedName, Country country, AdministrativeArea administrativeArea)
        {
            Version = version;
            Key = key;
            Type = type;
            Rank = rank;
            LocalizedName = localizedName;
            Country = country;
            AdministrativeArea = administrativeArea;
        }
    }
}

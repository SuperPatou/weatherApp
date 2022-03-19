using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.Classes
{
    public class Country
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }

        public Country (string id, string localizedName)
        {
            ID = id;
            LocalizedName = localizedName;
        }
    }
}

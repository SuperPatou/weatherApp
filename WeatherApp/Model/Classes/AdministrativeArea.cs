using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.Classes
{
    public class AdministrativeArea
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }

        public AdministrativeArea(string id, string localizedName)
        {
            ID = id;
            localizedName = localizedName;
        }
    }
}

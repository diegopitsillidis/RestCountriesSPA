using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnexioSPA.Models
{
    public class Countries
    {
        public List<CountryData> countries { get; set; } //not used
    }

    public class CountryData
    {
        public string flag { get; set; }
        public string name { get; set; }
        public string capital { get; set; }
        public List<currencies> Currencies { get; set; } //list of official currencies
        public int population { get; set; }
        public string alpha3Code { get; set; }
        public List<languages> Languages { get; set; } //list of official languages
    }

    public class currencies
    {
        public string name { get; set; }
    }

    public class languages
    {
        public string name { get; set; }
    }
}

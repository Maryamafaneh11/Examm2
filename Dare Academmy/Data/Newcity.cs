using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Dare_Academmy.Data
{
    public class Newcity
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string country { set; get; }

        public Newcountry country_id { set; get; }

    }
}

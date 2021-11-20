using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dare_Academmy.Data
{
    public class Newcountry
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public List<Newcity> city { set; get; }
    }
}

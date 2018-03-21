using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kruglikovHotels.Models
{
    public class City
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<Hotel> hotels { get; set; }
    }
}
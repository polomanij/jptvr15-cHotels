﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kruglikovHotels.Models
{
    public class Hotel
    {
        public int id { get; set }
        public string name { get; set }
        public string services { get; set }
        public string photo { get; set }
        public string adress { get; set }
    }
}
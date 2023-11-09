﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Location
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<GeoLocation> GeoLocations { get; set; }
    }
}

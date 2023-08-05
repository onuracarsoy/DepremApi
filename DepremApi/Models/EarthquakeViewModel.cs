using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepremApi.Models
{
    public class EarthquakeViewModel
    {

        public class Rootobject
        {
            public bool status { get; set; }
            public int httpStatus { get; set; }
            public int serverloadms { get; set; }
            public string desc { get; set; }
            public Metadata metadata { get; set; }
            public Result[] result { get; set; }
        }

        public class Metadata
        {
            public string date_starts { get; set; }
            public string date_ends { get; set; }
            public int total { get; set; }
        }

        public class Result
        {
            public string _id { get; set; }
            public string earthquake_id { get; set; }
            public string provider { get; set; }
            public string title { get; set; }
            public string date { get; set; }
            public float mag { get; set; }
            public float depth { get; set; }
            public Geojson geojson { get; set; }
            public Location_Properties location_properties { get; set; }
            public string rev { get; set; }
            public string date_time { get; set; }
            public int created_at { get; set; }
            public string location_tz { get; set; }
        }

        public class Geojson
        {
            public string type { get; set; }
            public float[] coordinates { get; set; }
        }

        public class Location_Properties
        {
            public Closestcity closestCity { get; set; }
            public Epicenter epiCenter { get; set; }
            public Closestcity1[] closestCities { get; set; }
            public Airport[] airports { get; set; }
        }

        public class Closestcity
        {
            public string name { get; set; }
            public int cityCode { get; set; }
            public float distance { get; set; }
            public int population { get; set; }
        }

        public class Epicenter
        {
            public string name { get; set; }
            public int cityCode { get; set; }
            public int? population { get; set; }
        }

        public class Closestcity1
        {
            public string name { get; set; }
            public int cityCode { get; set; }
            public float distance { get; set; }
            public int? population { get; set; }
        }

        public class Airport
        {
            public float distance { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public Coordinates coordinates { get; set; }
        }

        public class Coordinates
        {
            public string type { get; set; }
            public float[] coordinates { get; set; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HighCharts.Models
{
    public class ChartViewModel
    {
        public List<string> Categories { get; set; }
        public List<SeriesData> Series { get; set; }
    }

    public class SeriesData
    {
        public string name { get; set; }
        public List<double> data { get; set; }
    }

}
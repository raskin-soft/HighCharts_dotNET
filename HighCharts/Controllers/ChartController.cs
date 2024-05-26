using HighCharts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighCharts.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart

        public ActionResult Index()
        {
            //var model = new ChartViewModel
            //{
            //    Categories = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
            //    Series = new List<SeriesData>
            //{
            //    new SeriesData
            //    {
            //        name = "Tokyo",
            //        data = new List<double> { 7.0, 6.9, 9.5, 14.5, 18.4, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 }
            //    },
            //    new SeriesData
            //    {
            //        name = "London",
            //        data = new List<double> { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 }
            //    }
            //}
            //};

            //return View(model);

            return View();
        }


        // Action to fetch chart data based on chart type
        public ActionResult ChartData(string chartType)
        {
            // Dummy data - replace this with your actual data retrieval logic
            var categories = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            var seriesData = GenerateSeriesData();

            // Return data as JSON object
            return Json(new { chartType = chartType, categories = categories, series = seriesData }, JsonRequestBehavior.AllowGet);
        }

        // Dummy method to generate series data
        private List<object> GenerateSeriesData()
        {
            var random = new Random();
            var seriesData = new List<object>();

            // Generate random series data
            for (int i = 0; i < 3; i++)
            {
                var data = new List<int>();

                for (int j = 0; j < 12; j++)
                {
                    data.Add(random.Next(10, 100));
                }

                seriesData.Add(new { name = "Series " + (i + 1), data = data });
            }

            return seriesData;
        }

    }
}
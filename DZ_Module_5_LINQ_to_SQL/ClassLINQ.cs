using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using Separator = LiveCharts.Wpf.Separator;

namespace DZ_Module_5_LINQ_to_SQL
{
    public class ClassLINQ
    {
        CounriesDBDataContext db;
        string connectionStr;
        public ClassLINQ()
        {
            connectionStr = 
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            db = new CounriesDBDataContext(connectionStr);
        }

        public string LINQCountryName(string str)
        {
            var result = from item in db.Countris where item.ISO == str
                         select item.CountryName;
            return result.First();
        }

        public string LINQCapital(string str)
        {
            var result = from item in db.Countris where item.ISO == str
                         select item.Capital;
            return result.First();
        }

        public double LINQPopulations(string str)
        {
            var result = (from item in db.Countris where item.ISO == str 
                             select item.Populations).Single();
            return result;
        }

    }
}

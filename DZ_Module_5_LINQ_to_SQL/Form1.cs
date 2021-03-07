using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;



namespace DZ_Module_5_LINQ_to_SQL
{
    public partial class Form1 : Form
    {
        ClassLINQ classLINQ;
        
        public Form1()
        {
            InitializeComponent();
            classLINQ = new ClassLINQ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();

            Dictionary<string, string> keyValueCapital = new Dictionary<string, string>();
            Dictionary<string, double> keyValuePopulations = new Dictionary<string, double>();



            keyValueCapital["AU"] = classLINQ.LINQCountryName("AU") + "\n" + classLINQ.LINQCapital("AU");
            keyValueCapital["DE"] = classLINQ.LINQCountryName("DE") + "\n" + classLINQ.LINQCapital("DE");
            keyValueCapital["IN"] = classLINQ.LINQCountryName("DE") + "\n" + classLINQ.LINQCapital("IN");
            keyValueCapital["IN"] = classLINQ.LINQCountryName("DE") + "\n" + classLINQ.LINQCapital("IN");
            keyValueCapital["LA"] = classLINQ.LINQCountryName("DE") + "\n" + classLINQ.LINQCapital("LA");
            keyValueCapital["US"] = classLINQ.LINQCountryName("DE") + "\n" + classLINQ.LINQCapital("US");
            keyValueCapital["ZW"] = classLINQ.LINQCountryName("DE") + "\n" + classLINQ.LINQCapital("ZW");
            keyValueCapital["UA"] = classLINQ.LINQCountryName("DE") + "\n" + classLINQ.LINQCapital("UA");


            keyValuePopulations["AU"] = classLINQ.LINQPopulations("AU");
            keyValuePopulations["DE"] = classLINQ.LINQPopulations("DE");
            keyValuePopulations["IN"] = classLINQ.LINQPopulations("IN");
            keyValuePopulations["LA"] = classLINQ.LINQPopulations("LA");
            keyValuePopulations["US"] = classLINQ.LINQPopulations("US");
            keyValuePopulations["ZW"] = classLINQ.LINQPopulations("ZW");
            keyValuePopulations["UA"] = classLINQ.LINQPopulations("UA");

            geoMap.LanguagePack = keyValueCapital;
            geoMap.HeatMap = keyValuePopulations;
            geoMap.Hoverable = true;
            geoMap.Source = @"D:\IT STEP\ADO.NET\MakeHomeWork\DZ_Module_5_LINQ_to_SQL\DZ_Module_5_LINQ_to_SQL\World.xml";

            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;

        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_statistic_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_statistic_Click_2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using LiveCharts;
using LiveCharts.Wpf;

namespace DZ_Module_5_LINQ_to_SQL
{
    public class Form2 : Form
    {
        TextBox TextBox;
        ClassLINQ classLINQ;
        
        public Form2()
        {
           
            TextBox = new TextBox();
            classLINQ = new ClassLINQ();
            ClassStatistic classStatistic = new ClassStatistic();
            this.Controls.Add(TextBox);
            this.Show();
        }
        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            
        }

    }
}

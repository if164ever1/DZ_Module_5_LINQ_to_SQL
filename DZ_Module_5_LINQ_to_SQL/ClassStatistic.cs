using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DZ_Module_5_LINQ_to_SQL
{
    public class ClassStatistic
    {
        public TextBox textBox;
      
        ClassLINQ classLINQ;
        public ClassStatistic()
        {
            classLINQ = new ClassLINQ();
          
            textBox = new TextBox();

        }

    }
}

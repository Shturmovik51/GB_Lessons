using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HW_From_Prepod.Viewer
{
    class View
    {
        public TextBox date, tMin, tMax, pMin, pMax, wMin, wMax;
        public View(TextBox date, TextBox tMin, TextBox tMax, TextBox pMin, TextBox pMax, TextBox wMin, TextBox wMax)
        {
            this.date = date;
            this.tMin = tMin;
            this.tMax = tMax;
            this.pMin = pMin;
            this.pMax = pMax;
            this.wMin = wMin;
            this.wMax = wMax;
        }
    }
}

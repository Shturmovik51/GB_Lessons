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
        public TextBox date, tMin, tMax, pMin, pMax, wind, wDir;
        public View(TextBox date, TextBox tMin, TextBox tMax, TextBox pMin, TextBox pMax, TextBox wind, TextBox wDir)
        {
            this.date = date;
            this.tMin = tMin;
            this.tMax = tMax;
            this.pMin = pMin;
            this.pMax = pMax;
            this.wind = wind;
            this.wDir = wDir;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_From_Prepod.Viewer;
using HW_From_Prepod.MyEnetSearcher;
using System.Collections.ObjectModel;

namespace HW_From_Prepod.Printer
{    
    class Print
    {
        EnetSearcher es = new EnetSearcher();
        public ObservableCollection<View> views = new ObservableCollection<View>();
        public void ToPrint(string City)
        {
            for (int i = 0; i < views.Count; i++)
            {
                var model = es.GetWeatherModels(City)[i];
                views[i].date.Text = model.DateD + model.DateM + model.DateY + model.DateH;
                views[i].tMin.Text = model.TEMPERATUREmin;
                views[i].tMax.Text = model.TEMPERATUREmax;
                views[i].pMin.Text = model.PRESSUREmin;
                views[i].pMax.Text = model.PRESSUREmax;
                views[i].wMin.Text = model.WINDmin;
                views[i].wMax.Text = model.WINDmax;
            }
        }
    }
}

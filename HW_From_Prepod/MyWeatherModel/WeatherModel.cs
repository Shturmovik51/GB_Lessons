using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HW_From_Prepod.MyWeatherModel
{
    class WeatherModel
    {
        int dateD, dateM, dateY, dateH;       
        int tMin, tMax;
        int pMin, pMax;
        int wMin, wMax;

        public string DateD { get { return $"{dateD.ToString()}."; } set { int.TryParse(value, out dateD); } }
        public string DateM { get { return $"{dateM.ToString()}."; } set { int.TryParse(value, out dateM); } }
        public string DateY { get { return $"{dateY.ToString()} "; } set { int.TryParse(value, out dateY); } }
        public string DateH { get { return $"{dateH.ToString()}:00"; } set { int.TryParse(value, out dateH); } }
        
        public string TEMPERATUREmin { get { return $"{tMin.ToString()} ℃ "; } set { int.TryParse(value, out tMin); } }
        public string TEMPERATUREmax { get { return $"{tMax.ToString()} ℃ "; } set { int.TryParse(value, out tMax); } }
        public string PRESSUREmin { get { return $"{pMin.ToString()} мм.рт.ст."; } set { int.TryParse(value, out pMin); } }
        public string PRESSUREmax { get { return $"{pMax.ToString()} мм.рт.ст."; } set { int.TryParse(value, out pMax); } }
        public string WINDmin { get { return $"{wMin.ToString()} м/с"; } set { int.TryParse(value, out wMin); } }
        public string WINDmax { get { return $"{wMax.ToString()} м/с"; } set { int.TryParse(value, out wMax); } }
    }
}

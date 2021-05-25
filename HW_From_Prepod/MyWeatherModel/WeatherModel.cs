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
        int wMin, wMax, wDir;

        public string DateD { get { return $"{dateD.ToString()}."; } set { int.TryParse(value, out dateD); } }
        public string DateM { get { return $"{dateM.ToString()}."; } set { int.TryParse(value, out dateM); } }
        public string DateY { get { return $"{dateY.ToString()} "; } set { int.TryParse(value, out dateY); } }
        public string DateH { get { return $"{dateH.ToString()}:00"; } set { int.TryParse(value, out dateH); } }
        
        public string TEMPERATUREmin { get { return $"T min = {tMin.ToString()} ℃ "; } set { int.TryParse(value, out tMin); } }
        public string TEMPERATUREmax { get { return $"T max = {tMax.ToString()} ℃ "; } set { int.TryParse(value, out tMax); } }
        public string PRESSUREmin { get { return $"P min = {pMin.ToString()} мм.рт.ст."; } set { int.TryParse(value, out pMin); } }
        public string PRESSUREmax { get { return $"P max = {pMax.ToString()} мм.рт.ст."; } set { int.TryParse(value, out pMax); } }
        public string WINDmin { get { return $"Ветер от {wMin.ToString()} "; } set { int.TryParse(value, out wMin); } }
        public string WINDmax { get { return $"до {wMax.ToString()} м/с"; } set { int.TryParse(value, out wMax); } }
        public string WINDdir 
        { 
            get 
            {   
                if (wDir <= 10 && wDir >= 0 || wDir <= 360 && wDir >= 350 ) return $"направление C";
                if (wDir < 80 && wDir > 10) return $"направление CВ";
                if (wDir >= 80 && wDir <= 100) return $"направление В";
                if (wDir > 100 && wDir < 170) return $"направление ЮВ";
                if (wDir >= 170 && wDir <= 190) return $"направление Ю";
                if (wDir > 190 && wDir < 260) return $"направление ЮЗ";
                if (wDir >= 260 && wDir <= 280) return $"направление З";
                if (wDir > 280 && wDir < 350) return $"направление СЗ";
                else return "error";
            } 
            set { int.TryParse(value, out wDir); } 
        }
    }
}

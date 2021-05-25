using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HW_From_Prepod.Viewer;
using HW_From_Prepod.Printer;
using System.Collections.ObjectModel;

namespace HW_From_Prepod
{    
    public partial class MainWindow : Window
    {
        Print print = new Print();
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<View> allViews = new ObservableCollection<View>
            {
                new View(date1, tMin1, tMax1, pMin1, pMax1, wind1, wDir1),
                new View(date2, tMin2, tMax2, pMin2, pMax2, wind2, wDir2),
                new View(date3, tMin3, tMax3, pMin3, pMax3, wind3, wDir3),
                new View(date4, tMin4, tMax4, pMin4, pMax4, wind4, wDir4)
            };
            print.views = allViews;
        }
       

        private void murmVeather_Click(object sender, RoutedEventArgs e)
        {           
            print.ToPrint("Мурманск");
            win.Title = $"Weather Forecast {"М У Р М А Н С К", 80}";
        }

        private void moscowVeather_Click(object sender, RoutedEventArgs e)
        {           
            print.ToPrint("Москва");
            win.Title = $"Weather Forecast {"М О С К В А",80}";
        }

        private void piterVeather_Click(object sender, RoutedEventArgs e)
        {            
            print.ToPrint("Питер");
            win.Title = $"Weather Forecast {"С А Н К Т - П Е Т Е Р Б У Р Г",80}";
        }
    }
}

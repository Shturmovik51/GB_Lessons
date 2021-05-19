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

namespace HW_7_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Logics logics = new Logics();        
        public MainWindow()
        {
            InitializeComponent();
            logics.txt = txt;
            logics.bubble = bubble;
            logics.countlbl = count;
            logics.bestCountTXT = bestCount;
            logics.img1 = img1;
            logics.img2 = img2;
            logics.img3 = img3;
            logics.img4 = img4;
            logics.buttonStart = buttonStart;
            logics.buttonEnter = buttonEnter;
        }
            

        private void ButtonEnterNum(object sender, RoutedEventArgs e)
        {
            logics.OnEnterNum();
        }

        private void ButtonGenerateNum(object sender, RoutedEventArgs e)
        {
            logics.Generator();
        }
    }
}

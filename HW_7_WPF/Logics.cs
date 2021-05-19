using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HW_7_WPF
{
    class Logics
    {
        public TextBox txt;
        public Button buttonStart, buttonEnter;
        public TextBlock bestCountTXT;
        public Label bubble, countlbl;
        public Image img1, img2, img3, img4;
        int memory, count;
        
        
        public async void Generator()
        {
            buttonStart.IsEnabled = false;
            img1.Visibility = Visibility.Hidden;
            img4.Visibility = Visibility.Hidden;
            img2.Visibility = Visibility.Visible;            
            await Task.Delay(400);
            bubble.Content = ".";
            await Task.Delay(400);
            bubble.Content = ". .";
            await Task.Delay(400);
            bubble.Content = ". . .";
            await Task.Delay(400);
            Random rand = new Random();
            memory = rand.Next(1, 10);
            bubble.Content = "Загадал";
            txt.IsEnabled = true;
            buttonEnter.IsEnabled = true;
            img2.Visibility = Visibility.Hidden;
            img3.Visibility = Visibility.Visible;
        }

        public void OnEnterNum()
        {
            if (char.IsDigit(char.Parse(txt.Text)))
                bubble.Content = Messenger(Comparator(int.Parse(txt.Text)));
            else
            {
                txt.Text = string.Empty;
                bubble.Content = "Не число";
            }
        }

        public int Comparator(int number)
        {
            count++;
            countlbl.Content = count;
            txt.Text = string.Empty;
            return memory.CompareTo(number);
        }

        public string Messenger(int result)
        {
            if (result < 0) return "Мое меньше";
            else if (result > 0) return "Мое больше";
            else
            {
                img3.Visibility = Visibility.Hidden;
                img4.Visibility = Visibility.Visible;
                buttonStart.IsEnabled = true;
                txt.IsEnabled = false;
                buttonEnter.IsEnabled = false;
                countlbl.Content = string.Empty;

                if (bestCountTXT.Text == "пока нет" || count < int.Parse(bestCountTXT.Text)) bestCountTXT.Text = count.ToString();

                count = 0;
                return "Вы угадали";
            }
                
        }

    }
}

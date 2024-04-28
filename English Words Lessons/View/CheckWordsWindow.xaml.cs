using English_Words_Lessons.Model;
using English_Words_Lessons.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace English_Words_Lessons.View
{
    /// <summary>
    /// Логика взаимодействия для CheckWordsWindow.xaml
    /// </summary>
    public partial class CheckWordsWindow : Window
    {
        ObservableCollection<Word> Words;
        Random random = new Random();
        Word wordEng = new Word();
        Word wordRus = new Word();
        
         
       

        int n = 0;
        public CheckWordsWindow( ObservableCollection<Word> words )
        {
            InitializeComponent();
            Words = words;

            Words_Check_Display();
            


        }

        private void btn_Check(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            if (button != null)
            if (button.Content.ToString() == wordEng.RussianWord)
            {
                MessageBox.Show("Good Job");
                    Words_Check_Display();
                    
                }
                else
                {
                    MessageBox.Show("False");
                }

        }
      public void Words_Check_Display()
        {
            int index = random.Next(0, 3);
            wordEng = Words.ElementAt(random.Next(0, n));
            n = Words.Count;
            txtblk1.Text = wordEng.EnglishWord;
            Button btn = new Button();
            List<Button> buttons = new List<Button>()
           {
               btn1,
               btn2,
               btn3
           };
            btn = buttons.ElementAtOrDefault(index);
            btn.Content = wordEng.RussianWord;
            if (btn == btn1)
            {
                wordRus = Words.ElementAt(random.Next(0, n));
                btn2.Content = wordRus.RussianWord;
                wordRus = Words.ElementAt(random.Next(0, n));
                btn3.Content = wordRus.RussianWord;
            }
            else if (btn == btn2)
            {
                wordRus = Words.ElementAt(random.Next(0, n));
                btn1.Content = wordRus.RussianWord;
                wordRus = Words.ElementAt(random.Next(0, n));
                btn3.Content = wordRus.RussianWord;
            }
            else
            {
                wordRus = Words.ElementAt(random.Next(0, n));
                btn1.Content = wordRus.RussianWord;
                wordRus = Words.ElementAt(random.Next(0, n));
                btn2.Content = wordRus.RussianWord;
            }
        }
    }
}

using English_Words_Lessons.Model;
using English_Words_Lessons.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Words_Lessons.ViewModel
{
    internal class CheckWordsViewModel
    {
        RelayCommand? checkAllWordsCommand;

        public ObservableCollection<Word> Words { get; set; }


        public CheckWordsViewModel()
        {

        }
        public CheckWordsViewModel(ObservableCollection<Word> words)
        {
            Words = words;

        }
       

        public RelayCommand CheckAllCommand
        {
            get
            {
                return checkAllWordsCommand ??
                    (checkAllWordsCommand = new RelayCommand((o) =>
                    {
                        // Получаем коллекцию

                        CheckWordsWindow checkWordsWindow = new CheckWordsWindow(Words);
                        if (checkWordsWindow.ShowDialog() == true)
                        {

                        }
                    }));
            }
        }
    }
}

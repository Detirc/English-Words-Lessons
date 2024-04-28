using English_Words_Lessons.Model;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using English_Words_Lessons.View;
using System.Linq;
using System.Collections.Generic;

namespace English_Words_Lessons.ViewModel
{
    internal class ApplicationViewModel
    {
        ApplicationContext db = new ApplicationContext();
        RelayCommand? addCommand;
        RelayCommand? editCommand;
        RelayCommand? deleteCommand;
        RelayCommand? checkWordsCommand;
        public ObservableCollection<Word> Words { get; set; }
        public ApplicationViewModel()
        {
            db.Database.EnsureCreated();
            var firstTenWords = db.Words.Take(10).ToList();
            Words = new ObservableCollection<Word>(firstTenWords);
        }

            public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      WordWindow wordWindow = new WordWindow(new Word());
                      if (wordWindow.ShowDialog() == true)
                      {
                          Word word = wordWindow.Word;
                          db.Words.Add(word);
                          db.SaveChanges();
                      }
                  }));
            }
        }

        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((selectedItem) =>
                  {
                      // получаем выделенный объект
                      Word? word = selectedItem as Word;
                      if (word == null) return;

                      Word vm = new Word
                      {
                          Id = word.Id,
                          EnglishWord = word.EnglishWord,
                          RussianWord = word.RussianWord,
                          Transcription=word.Transcription
                      };
                      WordWindow wordWindow = new WordWindow(vm);


                      if (wordWindow.ShowDialog() == true)
                      {
                          word.EnglishWord = wordWindow.Word.EnglishWord;
                          word.RussianWord =wordWindow.Word.RussianWord;
                          db.Entry(word).State = EntityState.Modified;
                          db.SaveChanges();
                      }
                  }));
            }
        }
                // команда удаления
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand((selectedItem) =>
                  {
                      // получаем выделенный объект
                      Word? word = selectedItem as Word;
                      if (word == null) return;
                      db.Words.Remove(word);
                      db.SaveChanges();
                  }));
            }
        }
        // Команда проверки слов

        public RelayCommand CheckWordsCommand
        {
            get
            {
                return checkWordsCommand ??
                    (checkWordsCommand = new RelayCommand((o) =>
                    {
                        // Получаем коллекцию
                        
                        CheckWordsWindow checkWordsWindow = new CheckWordsWindow( Words);
                        if (checkWordsWindow.ShowDialog() == true)
                        {
                           
                        }
                    }));
            }
        }

        }

    }

    


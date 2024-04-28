using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace English_Words_Lessons.Model
{
  public   class Word : INotifyPropertyChanged
    {
        private string? englishWord;
        private string? russianWord;
        private string? transcription;
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }
        public string ?EnglishWord
        {
            get { return englishWord; }
            set { 
                englishWord = value;
                OnPropertyChanged();
            }
        }

        public string ?RussianWord
        {
            get { return russianWord; }
            set
            {
                russianWord = value;
                OnPropertyChanged();
            }
        }
        public string? Transcription
        {
            get { return transcription; }
            set
            {
                transcription = value;
                OnPropertyChanged();
            }
        }


        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

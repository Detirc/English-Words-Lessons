﻿using English_Words_Lessons.Model;
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
using System.Windows.Shapes;

namespace English_Words_Lessons.View
{
    /// <summary>
    /// Логика взаимодействия для WordWindow.xaml
    /// </summary>
    public partial class WordWindow : Window
    {
        public Word Word { get; private set; }
        public WordWindow(Word word)
        {
            InitializeComponent();
            Word = word;
            DataContext = Word;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}

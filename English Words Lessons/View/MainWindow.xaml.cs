using English_Words_Lessons.Model;
using English_Words_Lessons.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows;


namespace English_Words_Lessons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
           

        }

        
    }
}

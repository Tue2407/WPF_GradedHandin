using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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

namespace GradedExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();

            personListBox.ItemsSource = people;
            gridPerson.DataContext = people;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            string s = "";
            
            //people.Add(new Person("3;Tue;10;25"));
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                s = File.ReadAllText(openFileDialog.FileName);

            var list = s.Split(';');
            for (int i = 0; i < list.Length-4; i = i + 4)
            {
                people.Add(new Person(int.Parse(list[i]), list[i + 1], int.Parse(list[i + 2]), int.Parse(list[i+3])));
            }

            statusLabel.Content = "Users in list: " + personListBox.Items.Count + " - Uploaded: " + DateTime.Now;

        }

        private void personListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            personId.DataContext = personListBox.SelectedItem;
            personName.DataContext = personListBox.SelectedItem;
            personAge.DataContext = personListBox.SelectedItem;
            personScore.DataContext = personListBox.SelectedItem;
        }
    }

    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private int _age;
        private int _score;
        private int _id;

        public Person(int id, string name, int age, int score)
        {
            Id = id;
            Name = name;
            Age = age;
            Score = score;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                NotifyPropertyChanged(nameof(Age));
            }
        }

        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                NotifyPropertyChanged(nameof(Score));
            }
        }

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged(nameof(Id));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string ListBoxToString
        {
            get
            {
                return $"ID: {Id} - Name: {Name}";
            }
        }
    }
}

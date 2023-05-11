using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.IO;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace StudentCard
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public static string json = File.ReadAllText("students.json");
        private ObservableCollection<Students>? students = JsonConvert.DeserializeObject<ObservableCollection<Students>>(json);
        public Page2()
        {
            InitializeComponent();
            studentsGrid.ItemsSource = students;
        }

        // Метод загрузки списка студентов из файла и заполнения DataGrid
        //private void LoadStudents()
        //{
        //    using (StreamReader sr = new StreamReader("students.json"))
        //    {
        //        string jsonString = sr.ReadToEnd();
        //        students = System.Text.Json.JsonSerializer.Deserialize<ObservableCollection<Students>>(jsonString);
        //    }

        //    studentsGrid.ItemsSource = students;
        //}

        // Метод сохранения изменений в исходный файл
        private void SaveStudents()
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });

            using (StreamWriter sw = new StreamWriter("students.json"))
            {
                sw.Write(jsonString);
            }
        }

        private void Change_Button_Click(object sender, RoutedEventArgs e)
        {
            if(studentsGrid.IsReadOnly)
            {
                studentsGrid.IsReadOnly = false;
            }
            else
            {
                studentsGrid.IsReadOnly = true;
            }
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            SaveStudents();
            studentsGrid.Items.Refresh();
        }


        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            studentsGrid.Items.Refresh();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (studentsGrid.SelectedItem != null)
            {
                students?.RemoveAt(studentsGrid.SelectedIndex);
            }
        }
    }
}

using Newtonsoft.Json;
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
using System.IO;

namespace StudentCard
{
    /// <summary>
    /// Логика взаимодействия для Group2PK1.xaml
    /// </summary>
    public partial class Group2PK1 : Window
    {
        public Group2PK1()
        {
            InitializeComponent();
            string json = File.ReadAllText("student.json");
            Student student = JsonConvert.DeserializeObject<Student>(json);
            info.DataContext = student;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}

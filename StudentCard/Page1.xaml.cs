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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentCard
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            

            string text = Groups.Text;
            if (text== "2пк1" || text == "2gr1"|| text == "2pk1")
            {
                NavigationService.Navigate(new Page2());
            }
            else if (text== "2пк2" || text == "2gr2" || text == "2pk2")
            {
                NavigationService.Navigate(new Page3());
            }    
            else
            {
                MessageBox.Show("Группа введена неправильно\nПопробуйте еще раз");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            
        }

        private void Groups_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }


        private void Groups_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.Key == Key.Enter)
            {
                string text = Groups.Text;
                if (text == "2пк1" || text == "2gr1" || text == "2pk1")
                {
                    NavigationService.Navigate(new Page2());
                }
                else if (text == "2пк2" || text == "2gr2" || text == "2pk2")
                {
                    NavigationService.Navigate(new Page3());
                }
                else
                {
                    MessageBox.Show("Группа введена неправильно\nПопробуйте еще раз");
                }
            }
            
        }

        
    }
}

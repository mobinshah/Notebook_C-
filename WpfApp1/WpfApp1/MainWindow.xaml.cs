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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<student> s = new List<student>();


            //foreach (var item in collection)
            //{

            //}
        }
    }


    public class student
    {
        public string name;
        public string family;
        public string city;
        public int age;

        public student(string name, string family, string city, int age)
        {
            this.name = name;
            this.family = family;
            this.city = city;
            this.age = age;
        }
    }
}

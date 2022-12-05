using System;
using System.Collections.Generic;
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
using RomaniaLibrary;

namespace Romania
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int gender,resident;
        public MainWindow()
        {
            InitializeComponent();
            GenerateList();
        }

        private void GenerateList()
        {
            string[] readText = File.ReadAllLines(@"C: \Users\311 - 20(student)\source\repos\Romania\Romania\bin\Debug");
            List<string> list = new List<string> { };
            foreach (var item in readText)
            {
              string[] result= item.Split();
                list.Add(result[2]);
            }
        }

        private void GenerateCNP_Click(object sender, RoutedEventArgs e)
        {
            CodeClass obj = new CodeClass();
            if (Male.IsChecked==true)
            {
                gender = 1;
            }
            else
            {
                gender = 2;
            }
            if (RadioButtonYes.IsChecked==true)
            {
                resident = 1;
            }
            else
            {
                resident = 2;
            }
             obj.GenerateCode(LastName.Text, gender,DateOfBirth.SelectedDate,)

        }
    }
}

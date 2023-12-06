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

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Student> students = new List<Student>();



        public MainWindow()
        {
            InitializeComponent();
            PopulateStudents();
            lvDisplayList.ItemsSource = students;

           
            lvDisplayList.SelectedIndex = 0;
        }

        private void PopulateStudents()
        {
           
            students.Add(new Student("John", "Doe"));
            students.Add(new Student("Jane", "Smith"));
            students.Add(new Student("Jotaro", "Kujo"));
            students.Add(new Student("Ken", "Masters"));
            students.Add(new Student("Banjo", "Kazooie"));
          
        } 

        private void lvDisplayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (lvDisplayList.SelectedIndex != -1)
            {
               
                Student selectedStudent = students[lvDisplayList.SelectedIndex];

                MessageBox.Show($"Full Name: {selectedStudent._firstName} {selectedStudent._lastName}");
            }
        }
    }
}

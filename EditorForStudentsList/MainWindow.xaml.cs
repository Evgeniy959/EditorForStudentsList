using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DataModel;

namespace EditorForStudentsList
{
    public partial class MainWindow : Window
    {
        private StudentsList _list;
        private DataBase.Lib.DataBase _db;
        
        public MainWindow()
        {
            InitializeComponent();
            
            _db = new DataBase.Lib.DataBase();
            _list = _db.GetAllStudents();

            ListOfStudents.ItemsSource = _list.Students;
        }

        private void ListOfStudents_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedStudent = (sender as ListView)?.SelectedItem as Student;
        }
    }
}
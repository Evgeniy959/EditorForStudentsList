using System.Windows;
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
    }
}
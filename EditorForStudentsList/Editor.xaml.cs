using System.Linq;
using System.Windows;
using DataModel;

namespace EditorForStudentsList
{
    public partial class Editor : Window
    {
        private Student _student;
        public Editor(Student student)
        {
            _student = student;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            LastName.Text = _student.LastName;
            FirstName.Text = _student.FirstName;
            DateOfBirth.Text = _student.DateOfBirth;
            foreach (var phone in _student.Phones)
            {
                Phones.Text += $"{phone}; ";
            }

            Email.Text = _student.Email;
            IsStudy.IsChecked = _student.IsStudy;
            Faculty.Text = _student.Faculty;
        }

        private void Button_Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Clear_OnClick(object sender, RoutedEventArgs e)
        {
            LastName.Clear();
            FirstName.Clear();
            DateOfBirth.Clear();
            Phones.Clear();
            Email.Clear();
            IsStudy.IsChecked = false;
            Faculty.Clear();
        }

        private void Button_Save_OnClick(object sender, RoutedEventArgs e)
        {
            _student.LastName = LastName.Text;
            _student.FirstName = FirstName.Text;
            _student.DateOfBirth = DateOfBirth.Text;
            _student.Phones = Phones.Text.Split(';').ToList();
            _student.Email = Email.Text;
            _student.IsStudy = (bool)IsStudy.IsChecked;
            _student.Faculty = Faculty.Text;
            
            var db = new DataBase.Lib.DataBase();
            var result = db.UpdateStudent(_student);
            StatusBar.Content = result.IsAcknowledged;
        }
    }
}
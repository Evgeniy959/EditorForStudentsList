using System.Windows;
using DataModel;

namespace EditorForStudentsList
{
    public partial class Editor : Window
    {
        private Student _student;
        public Editor(Student student)
        {
            InitializeComponent();
            _student = student;
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
    }
}
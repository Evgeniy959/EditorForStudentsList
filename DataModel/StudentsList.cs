using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Sockets;

namespace DataModel
{
    public class StudentsList
    {
        public ObservableCollection<Student> Students;

        public StudentsList(IEnumerable<Student> students)
        {
            Students = new ObservableCollection<Student>(students);
        }

        public StudentsList()
        {
            Students = new ObservableCollection<Student>();
        }

        public static void ExportToXMLFile(ObservableCollection<Student> students)
        {
            //TODO Реализовать метод
        }

        public static ObservableCollection<Student> ImportFromXMLFile(string path)
        {
            //TODO Реализовать метод

            return new ObservableCollection<Student>();
        }
    }
}
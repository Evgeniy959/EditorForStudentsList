using System;
using DataModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataBase.Lib
{
    public class DataBase
    {
        private const string connectionString = "mongodb://localhost:27017";
        private MongoClient _client;

        public DataBase()
        {
            _client = new MongoClient(connectionString);
        }

        public StudentsList GetAllStudents()
        {
            var database = _client.GetDatabase("test");
            var collection = database.GetCollection<Student>("students");
            var students = collection.Find(new BsonDocument()).ToList();
            
            return new StudentsList(students);
        }

        public void AddStudent(Student student)
        {
            //TODO Реализовать метод
        }

        public void UpdateStudent(Student student)
        {
            //TODO Реализовать метод
        }
    }
}
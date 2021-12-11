using DataModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataBase.Lib
{
    public class DataBase
    {
        private const string connectionString = "mongodb://localhost:27017";
        private MongoClient _client;
        private IMongoCollection<Student> _collection;

        public DataBase()
        {
            _client = new MongoClient(connectionString);
        }

        private void DbConnection()
        {
            var database = _client.GetDatabase("test");
            _collection = database.GetCollection<Student>("students");
        }

        public StudentsList GetAllStudents()
        {
            DbConnection();
            var students = _collection.Find(new BsonDocument()).ToList();
            
            return new StudentsList(students);
        }

        public void AddStudent(Student student)
        {
            DbConnection();
            _collection.InsertOne(student);
        }

        public void UpdateStudent(Student student)
        {
            DbConnection();
            _collection.ReplaceOne(Builders<Student>.Filter.Eq("Id", student.Id), student);
        }
    }
}
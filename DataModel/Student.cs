using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataModel
{
    public class Student
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; } //BUG неверный тип данных
        public List<string> Phones { get; set; }
        public string Email { get; set; }
        public bool IsStudy { get; set; }
        public string Faculty { get; set; }
    }
}
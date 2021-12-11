using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace DataModel
{
    public class Student
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string> Phones { get; set; }
        public string Email { get; set; }
        public bool IsStudy { get; set; }
        public string Faculty { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text.Json;
using MongoDB.Bson;

namespace DataModel
{
    public class Student
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public List<string> Phones { get; set; }
        public string Email { get; set; }
        public bool IsStudy { get; set; }
        public string Faculty { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, typeof(Student));
        }
    }
}
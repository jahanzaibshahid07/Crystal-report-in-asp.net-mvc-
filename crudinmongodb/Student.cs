using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace crudinmongodb
{
    class Student
    {

        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("rollno")]
        public int rollno { get; set; }

        [BsonElement("totalmark")]
        public int totalmark { get; set; }

        [BsonElement("gpa")]
        public double gpa { get; set; }


        public Student(string name, int rollno, int totalmark, double gpa)
        {
            this.name = name;
            this.rollno = rollno;
            this.totalmark = totalmark;
            this.gpa = gpa;
        }
    }
}

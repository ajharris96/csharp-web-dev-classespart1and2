using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor);
        }


        public override string ToString()
        {
            string combindedString = "";
            for (int i = 0; i < enrolledStudents.Count; i++)
            {
                combindedString += enrolledStudents[i].Name + ", ";
            }
             
            return Topic + " is taught by: " + Instructor.FirstName + " " + Instructor.LastName + " and has these students: " + combindedString;
        }


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
    }
}
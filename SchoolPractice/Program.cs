using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student Andrew = new Student("Andrew");
            Student Sahva = new Student("Sahva");
            Console.WriteLine(Andrew.ToString());
            Course astro = new Course();
            astro.Topic = "General Relativity";
            Teacher Desika = new Teacher("Desika", "Narayanan", "Astrophysics", 6);
            astro.Instructor = Desika;
            List<Student> students = new List<Student>();
            students.Add(Andrew);
            students.Add(Sahva);
            astro.enrolledStudents = students;
            Console.WriteLine(astro.ToString());


        }
    }
}
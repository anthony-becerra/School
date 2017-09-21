using System;
using System.Collections.Generic;
using System.Text;

namespace School
{

    public class Student
    {

        private static int nextStudentId = 1; // Use to auto-increment StudentIds
        public string Name { get; private set; } //Name will be readable by everyone, but modifiable only by code within the class' assembly.
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        // For transfer students with credits & gpa
        public Student(string name, int numberOfCredits,
        double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        // For new students
        public Student(string name)
        : this(name, 0, 0) { }

        public override string ToString()
        {
            return "Name: " + Name + "\nID: " + StudentId
                + "\nNumber of Credits: " + NumberOfCredits
                + "\nGPA: " + Gpa;
        }

    }
}
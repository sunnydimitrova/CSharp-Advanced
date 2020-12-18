using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Classroom
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string subject;

        public Student(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }        

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public override string ToString()
        {
            return $"Student: First Name = {FirstName}, Last Name = {LastName}, Subject = {Subject}";
        }

    }
}

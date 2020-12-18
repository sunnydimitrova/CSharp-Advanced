using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Classroom
{
    public class Classroom
    {
        private List<Student> students;
        private int capacity;
        public int Count => students.Count;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>();
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string RegisterStudent(Student student)
        {
            if (Capacity > Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student firstNameForRemove = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (students.Contains(firstNameForRemove))
            {
                Students.Remove(firstNameForRemove);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return $"Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($"Students:");
            foreach (var student in students.FindAll(x => x.Subject == subject))
            {
                sb.AppendLine($"{student.FirstName} {student.LastName}");
            }
            if (sb.Length == 0)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                return sb.ToString().TrimEnd();
            }            
        }

        public int GetStudentsCount()
        {          
                return students.Count;            
        }

        public Student GetStudent(string firstName, string lastName)
        {
            
              var studentToGet = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            return studentToGet;
        }
    }
}
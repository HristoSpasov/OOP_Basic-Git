using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleJudje.Models
{
    class Course
    {
        public const int NumberOfTasksOnExam = 5;
        public const int MaxScoresOnExamTask = 100;

        private string name;
        private Dictionary<string, Student> studentsByName;

        public Course(string name)
        {
            this.name = name;
            this.studentsByName = new Dictionary<string, Student>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Dictionary<string, Student> StudentsByName
        {
            get { return this.studentsByName; }
        }

        public void EnrollStudent(Student student)
        {
            if (this.studentsByName.ContainsKey(student.UserName))
            {
                OutputWriter.DisplayException(string.Format(ExceptiionMessages.StudentAlreadyEnrolledInGivenCourse, student.UserName, this.Name));
                return;
            }

            this.studentsByName.Add(student.UserName, student);
        }
    }
}

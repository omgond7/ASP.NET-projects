using System.Collections.Generic;

namespace July11_Task
{
    public abstract class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public List<Course> EnrolledCourses { get; set; }

        protected Student(string id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
            EnrolledCourses = new List<Course>();
        }

        public int TotalCredits
        {
            get
            {
                int sum = 0;
                foreach (var course in EnrolledCourses)
                {
                    sum += course.Credits;
                }
                return sum;
            }
        }

        public abstract string StudentType { get; }

        public abstract double CalculateFee();
    }
}

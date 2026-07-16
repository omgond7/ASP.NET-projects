using System;
using System.Collections.Generic;

namespace July11_Task
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Course> courses = new List<Course>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Student Management");
                Console.WriteLine("2. Course Management");
                Console.WriteLine("3. Register Course");
                Console.WriteLine("4. View Student Details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine() ?? "";
                switch (choice)
                {
                    case "1":
                        StudentManagement();
                        break;
                    case "2":
                        CourseManagement();
                        break;
                    case "3":
                        RegisterCourse();
                        break;
                    case "4":
                        ViewStudentDetails();
                        break;
                    case "5":
                        Console.WriteLine("Exiting application.");
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        static void StudentManagement()
        {
            Console.WriteLine("\n--- Student Management ---");
            Console.WriteLine("1. Register a new student");
            Console.WriteLine("2. View all registered students");
            Console.WriteLine("3. Search student by ID");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    RegisterStudent();
                    break;
                case "2":
                    ViewAllStudents();
                    break;
                case "3":
                    SearchStudentById();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void RegisterStudent()
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine() ?? "";

            if (FindStudentById(id) != null)
            {
                Console.WriteLine("A student with this ID already exists.");
                return;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter Department: ");
            string dept = Console.ReadLine() ?? "";

            Console.WriteLine("Select Student Type:");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Scholarship");
            Console.WriteLine("3. Part-Time");
            Console.Write("Enter option: ");
            string typeOption = Console.ReadLine() ?? "";

            Student student;
            if (typeOption == "1")
            {
                student = new RegularStudent(id, name, dept);
            }
            else if (typeOption == "2")
            {
                student = new ScholarshipStudent(id, name, dept);
            }
            else if (typeOption == "3")
            {
                student = new PartTimeStudent(id, name, dept);
            }
            else
            {
                Console.WriteLine("Invalid student type selection.");
                return;
            }

            students.Add(student);
            Console.WriteLine("Student registered successfully.");
        }

        static void ViewAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No registered students found.");
                return;
            }

            Console.WriteLine("\nRegistered Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"- ID: {student.Id}, Name: {student.Name}, Dept: {student.Department}, Type: {student.StudentType}");
            }
        }

        static void SearchStudentById()
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine() ?? "";
            var student = FindStudentById(id);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                Console.WriteLine($"Student Found - ID: {student.Id}, Name: {student.Name}, Dept: {student.Department}, Type: {student.StudentType}");
            }
        }

        static void CourseManagement()
        {
            Console.WriteLine("\n--- Course Management ---");
            Console.WriteLine("1. Add new course");
            Console.WriteLine("2. Display all available courses");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    AddCourse();
                    break;
                case "2":
                    DisplayAllCourses();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void AddCourse()
        {
            Console.Write("Enter Course ID: ");
            string id = Console.ReadLine() ?? "";

            if (FindCourseById(id) != null)
            {
                Console.WriteLine("A course with this ID already exists.");
                return;
            }

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter Credits: ");
            if (!int.TryParse(Console.ReadLine() ?? "", out int credits))
            {
                Console.WriteLine("Invalid credit value. Course registration failed.");
                return;
            }

            var course = new Course(id, name, credits);
            courses.Add(course);
            Console.WriteLine("Course added successfully.");
        }

        static void DisplayAllCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No available courses.");
                return;
            }

            Console.WriteLine("\nAvailable Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"- ID: {course.CourseId}, Name: {course.CourseName}, Credits: {course.Credits}");
            }
        }

        static void RegisterCourse()
        {
            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine() ?? "";
            var student = FindStudentById(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter Course ID: ");
            string courseId = Console.ReadLine() ?? "";
            var course = FindCourseById(courseId);

            if (course == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }

            // Check if duplicate course registration
            if (student.EnrolledCourses.Exists(c => c.CourseId.Equals(courseId, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Student is already registered in this course.");
                return;
            }

            // Limit enrollment to a maximum (e.g. 5 courses)
            if (student.EnrolledCourses.Count >= 5)
            {
                Console.WriteLine("Cannot enroll. Student has reached the maximum course limit of 5.");
                return;
            }

            student.EnrolledCourses.Add(course);
            Console.WriteLine("Student enrolled in course successfully.");
        }

        static void ViewStudentDetails()
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine() ?? "";
            var student = FindStudentById(id);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine($"\nStudent Details:");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Department: {student.Department}");
            Console.WriteLine($"Type: {student.StudentType}");
            
            Console.WriteLine("Enrolled Courses:");
            if (student.EnrolledCourses.Count == 0)
            {
                Console.WriteLine("  No enrolled courses.");
            }
            else
            {
                foreach (var course in student.EnrolledCourses)
                {
                    Console.WriteLine($"  - {course.CourseId}: {course.CourseName} (Credits: {course.Credits})");
                }
            }

            Console.WriteLine($"Total Credits: {student.TotalCredits}");
            Console.WriteLine($"Total Fee: ${student.CalculateFee()}");
        }

        static Student? FindStudentById(string id)
        {
            return students.Find(s => s.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        static Course? FindCourseById(string id)
        {
            return courses.Find(c => c.CourseId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }
    }
}

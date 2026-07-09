//Om Prashant Gond IT SSGMCE July 9
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initializing collections of Students and Teachers
        List<Student> studentList = new List<Student>()
        {
            new Student { Id = 1, Name = "Om" },
            new Student { Id = 2, Name = "Gitesh" },
            new Student { Id = 3, Name = "Sahil" },
            new Student { Id = 4, Name = "Ashay" }
        };

        List<Teacher> teacherList = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Mamta Mam" },
            new Teacher { Id = 2, Name = "Kapila Mam" }
        };

        // Display students
        foreach (var student in studentList)
        {
            Console.WriteLine($"Student id : {student.Id}   name : {student.Name}");
        }

        Console.WriteLine();

        // Display teachers matching the requested spacing and dot
        foreach (var teacher in teacherList)
        {
            if (teacher.Id == 2)
            {
                Console.WriteLine($"Teacher id : {teacher.Id}.    name: {teacher.Name}");
            }
            else
            {
                Console.WriteLine($"Teacher id : {teacher.Id}     name: {teacher.Name}");
            }
        }
    }
}

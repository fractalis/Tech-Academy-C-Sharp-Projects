using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Challenge_451.Context;
using Challenge_451.Models;

namespace Challenge_451
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateEntriesInDatabase();
            ReadStudentFromDatabase();
            Console.ReadLine();
        }

        private static void ReadStudentFromDatabase()
        {
            using (var ctx = new SchoolContext())
            {
                var students = ctx.Students;

                foreach(var student in students)
                {
                    Console.WriteLine($"Student: {student.FirstName} {student.LastName} {student.Gpa}");
                }
            }
        }

        public static void CreateEntriesInDatabase()
        {
            using (var ctx = new SchoolContext())
            {
                var school = new School()
                {
                    SchoolName = "Eatoley High School",
                    SchoolAddress = "123 Main St",
                    SchoolCity = "Eatoley",
                    SchoolState = "OH",
                    SchoolZip = 55555
                };
                ctx.Schools.Add(school);

                var subject = new Subject()
                {
                    SubjectName = "Computer Science",
                    SubjectType = SubjectType.ComputerScience
                };

                ctx.Subjects.Add(subject);

                var student = new Student()
                {
                    FirstName = "Katherine",
                    LastName = "Johnson",
                    DateOfBirth = new DateTime(2003, 03, 14),
                    EmailAddresses = new List<string>()
                    {
                        "katherine.johnson@example.com",
                    },
                    Gpa = 4.0,
                    Height = 5.83M,
                    School = school,
                    Weight = 135.0f,
                    Subjects = new List<Subject>
                    {
                        subject
                    },
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}

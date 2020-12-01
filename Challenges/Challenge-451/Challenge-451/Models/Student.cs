using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_451.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public double Gpa { get; set; }
        
        public virtual List<Subject> Subjects { get; set; }
        public List<string> EmailAddresses { get; set; }

        public int SchoolId { get; set; }
        public virtual School School { get; set; }

    }
}

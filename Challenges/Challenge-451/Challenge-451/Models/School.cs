using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_451.Models
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolCity { get; set; }
        public string SchoolState { get; set; }
        public int SchoolZip { get; set; }
        public string SchoolWebsite { get; set; }
        public virtual List<Student> SchoolStudents {get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_451.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public SubjectType SubjectType { get; set; }
        public string SubjectName { get; set; }
    }
}

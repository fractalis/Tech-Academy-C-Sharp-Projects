using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Challenge_451.Models;

namespace Challenge_451.Context
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }

    
}

using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Ifra.Data.Context
{
    public   class UniversityDBConext:DbContext
    {
        public UniversityDBConext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}

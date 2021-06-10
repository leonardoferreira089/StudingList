using CSO_LF089.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSO_LF089.Data
{
    public class CsoDbContext : IdentityDbContext
    {
        public CsoDbContext(DbContextOptions<CsoDbContext> options)
            : base(options)
        {
        }

        public DbSet<CourseOrganizer> CursesOrganizer { get; set; }
        public DbSet<Book> books { get; set; }
    }
}

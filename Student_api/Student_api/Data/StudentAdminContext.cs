﻿using Microsoft.EntityFrameworkCore;

namespace Student_api.Data
{
    public class StudentAdminContext: DbContext
    {

        public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options) { }



        public DbSet<Students> Student { get; set; }
        
        public DbSet<Gender> Gender { get; set; }

        public DbSet<Address> Address { get; set; } 


    }
}

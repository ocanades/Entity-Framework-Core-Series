﻿using Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new EvaluationConfiguration());
        }

        public DbSet<Student> Students { get; set;}
    }
}

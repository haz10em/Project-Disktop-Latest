﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySchool
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolDBEntities : DbContext
    {
        public SchoolDBEntities()
            : base("name=SchoolDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Divisions> Divisions { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Guardians> Guardians { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Salarys> Salarys { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Stages> Stages { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<SubjectStudents> SubjectStudents { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<TeacherSubjectStudent> TeacherSubjectStudent { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Years> Years { get; set; }

        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<MONTH> MONTHS { get; set; }

    }
}

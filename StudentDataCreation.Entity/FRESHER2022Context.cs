﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentDataCreation.Entity
{
    public partial class FRESHER2022Context : DbContext
    {
        public FRESHER2022Context()
        {
        }

        public FRESHER2022Context(DbContextOptions<FRESHER2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentDataCreationS> StudentDataCreationS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.100.220;Initial Catalog=FRESHER2022;User ID=sa;Password=Chennai@2018#");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<StudentDataCreationS>(entity =>
            {
                entity.HasKey(e => e.StudentID);

                entity.Property(e => e.Create_Time_Stamp).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.StudentFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentSecondName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Update_Time_Stamp).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
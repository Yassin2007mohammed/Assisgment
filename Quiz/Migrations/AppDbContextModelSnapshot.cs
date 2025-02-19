﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiz.Models;

#nullable disable

namespace Quiz.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Quiz.Models.Entites.Assigment", b =>
                {
                    b.Property<int>("AssigmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssigmentId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tid")
                        .HasColumnType("int");

                    b.Property<int>("subid")
                        .HasColumnType("int");

                    b.HasKey("AssigmentId");

                    b.HasIndex("Tid");

                    b.HasIndex("subid");

                    b.ToTable("Assigments");
                });

            modelBuilder.Entity("Quiz.Models.Entites.Subjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Douration")
                        .HasColumnType("datetime2");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Quiz.Models.Entites.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spelization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Quiz.Models.Entites.Assigment", b =>
                {
                    b.HasOne("Quiz.Models.Entites.Teacher", "Teacher")
                        .WithMany("Assigments")
                        .HasForeignKey("Tid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quiz.Models.Entites.Subjects", "Subjects")
                        .WithMany("Assigments")
                        .HasForeignKey("subid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Quiz.Models.Entites.Subjects", b =>
                {
                    b.Navigation("Assigments");
                });

            modelBuilder.Entity("Quiz.Models.Entites.Teacher", b =>
                {
                    b.Navigation("Assigments");
                });
#pragma warning restore 612, 618
        }
    }
}

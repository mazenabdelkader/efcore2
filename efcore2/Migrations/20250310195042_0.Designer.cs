﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efcore2;

#nullable disable

namespace efcore2.Migrations
{
    [DbContext(typeof(db))]
    [Migration("20250310195042_0")]
    partial class _0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("efcore2.Course_stud", b =>
                {
                    b.Property<int>("course_idid")
                        .HasColumnType("int");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.Property<int>("stud_idid")
                        .HasColumnType("int");

                    b.HasIndex("course_idid");

                    b.HasIndex("stud_idid");

                    b.ToTable("stud_Courses");
                });

            modelBuilder.Entity("efcore2.course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("topicid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("topicid");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("efcore2.course_inst", b =>
                {
                    b.Property<int>("course_idid")
                        .HasColumnType("int");

                    b.Property<int>("evalute")
                        .HasColumnType("int");

                    b.Property<int>("inst_idid")
                        .HasColumnType("int");

                    b.HasIndex("course_idid");

                    b.HasIndex("inst_idid");

                    b.ToTable("course_Insts");
                });

            modelBuilder.Entity("efcore2.department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("hiring_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("insid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("efcore2.instructor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bonus")
                        .HasColumnType("int");

                    b.Property<int>("dept_id")
                        .HasColumnType("int");

                    b.Property<int>("hourrate")
                        .HasColumnType("int");

                    b.Property<int>("mangedepartmentid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("dept_id");

                    b.HasIndex("mangedepartmentid");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("efcore2.student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<int>("departmentid")
                        .HasColumnType("int");

                    b.Property<int>("dept_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("student");
                });

            modelBuilder.Entity("efcore2.topic", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("topic");
                });

            modelBuilder.Entity("efcore2.Course_stud", b =>
                {
                    b.HasOne("efcore2.course", "course_id")
                        .WithMany()
                        .HasForeignKey("course_idid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efcore2.student", "stud_id")
                        .WithMany()
                        .HasForeignKey("stud_idid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course_id");

                    b.Navigation("stud_id");
                });

            modelBuilder.Entity("efcore2.course", b =>
                {
                    b.HasOne("efcore2.topic", "topic")
                        .WithMany()
                        .HasForeignKey("topicid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("topic");
                });

            modelBuilder.Entity("efcore2.course_inst", b =>
                {
                    b.HasOne("efcore2.course", "course_id")
                        .WithMany()
                        .HasForeignKey("course_idid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efcore2.instructor", "inst_id")
                        .WithMany()
                        .HasForeignKey("inst_idid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course_id");

                    b.Navigation("inst_id");
                });

            modelBuilder.Entity("efcore2.instructor", b =>
                {
                    b.HasOne("efcore2.department", "department")
                        .WithMany()
                        .HasForeignKey("dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efcore2.department", "mangedepartment")
                        .WithMany()
                        .HasForeignKey("mangedepartmentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");

                    b.Navigation("mangedepartment");
                });

            modelBuilder.Entity("efcore2.student", b =>
                {
                    b.HasOne("efcore2.department", "department")
                        .WithMany()
                        .HasForeignKey("departmentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });
#pragma warning restore 612, 618
        }
    }
}

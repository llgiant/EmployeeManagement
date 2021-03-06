﻿// <auto-generated />
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200616042906_AddPhotoPathColumn")]
    partial class AddPhotoPathColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = 1,
                            Email = "Vika@mail.ru",
                            Name = "Vika"
                        },
                        new
                        {
                            Id = 2,
                            Department = 2,
                            Email = "vika@mail.ru",
                            Name = "Viktoria"
                        },
                        new
                        {
                            Id = 3,
                            Department = 2,
                            Email = "Roman@mail.ru",
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 4,
                            Department = 1,
                            Email = "Kira2@mail.ru",
                            Name = "Kira2"
                        },
                        new
                        {
                            Id = 5,
                            Department = 2,
                            Email = "vika2@mail.ru",
                            Name = "Viktoria2"
                        },
                        new
                        {
                            Id = 6,
                            Department = 2,
                            Email = "Roman2@mail.ru",
                            Name = "Roman2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

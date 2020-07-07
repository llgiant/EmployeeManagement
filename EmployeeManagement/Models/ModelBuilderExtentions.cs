using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Vika", Department = Dept.HR, Email = "Vika@mail.ru" },
                new Employee() { Id = 2, Name = "Viktoria", Department = Dept.IT, Email = "vika@mail.ru" },
                new Employee() { Id = 3, Name = "Roman", Department = Dept.IT, Email = "Roman@mail.ru" },
                new Employee() { Id = 4, Name = "Kira2", Department = Dept.HR, Email = "Kira2@mail.ru" },
                new Employee() { Id = 5, Name = "Viktoria2", Department = Dept.IT, Email = "vika2@mail.ru" },
                new Employee() { Id = 6, Name = "Roman2", Department = Dept.IT, Email = "Roman2@mail.ru" }
                );
        }
    }
}

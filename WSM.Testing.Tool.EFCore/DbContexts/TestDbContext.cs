using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WSM.Testing.Tool.EFCore.Models;

namespace WSM.Testing.Tool.EFCore.DbContexts
{
    public class TestDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Section> Sections { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=test.db");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual void Init()
        {
            Database.EnsureCreated();
        }
        public virtual void SeedSections()
        {
            Init();
            Sections.AddRange(GetFakeSectionsDataForAdd());
            SaveChanges();
        }
        public virtual void SeedEmployees()
        {
            Init();
            Employees.AddRange(GetFakeRandomEmployeesDataForAdd(100));
            SaveChanges();
        }
        public virtual List<Section> GetFakeSectionsDataForAdd() => new()
        {
            new() { Name = "Section1", MaxEmployees = 10 },
            new() { Name = "Section2", MaxEmployees = 15 },
            new() { Name = "Section3", MaxEmployees = 5 },
            new() { Name = "Section4", MaxEmployees = 10 },
            new() { Name = "Section5", MaxEmployees = 20 },
            new() { Name = "Section6", MaxEmployees = 44 },
        };
        public virtual List<Employee> GetFakeEmployeesDataForAdd() => new()
        {
            new() { Name = "Emp1", Phone = "1827165", SectionId=1 },
            new() { Name = "Emp2", Phone = "9276241", SectionId=4 },
            new() { Name = "Emp3", Phone = "3981761", SectionId=3 },
            new() { Name = "Emp4", Phone = "4982615", SectionId=4 },
            new() { Name = "Emp5", Phone = "3981635", SectionId=2 },
        };


        public virtual List<Employee> GetFakeRandomEmployeesDataForAdd(int numbers = 15) => Enumerable.Range(0, numbers).Select(_ =>
        {
            var randomCount = GetFakeEmployeesNamesDataForAdd.Value.Count;
            var randomIndex = Random.Shared.Next(0, randomCount - 1);
            var randomIndexLast = Random.Shared.Next(0, randomCount - 1);
            var name = GetFakeEmployeesNamesDataForAdd.Value[randomIndex];
            var lastName = GetFakeEmployeesNamesDataForAdd.Value[randomIndexLast];

            return new Employee()
            {
                FullName = name + " " + lastName,
                Name = name,
                Phone = Random.Shared.Next(10000, 99999).ToString(),
                SectionId = Random.Shared.Next(1, 5)
            };
        }).ToList();
        #region Just Names
        public virtual Lazy<List<string>> GetFakeEmployeesNamesDataForAdd => new(() => new()
        {
            "Adam",
            "Adrian",
            "Alan",
            "Alexander",
            "Andrew",
            "Anthony",
            "Austin",
            "Benjamin",
            "Blake",
            "Boris",
            "Brandon",
            "Brian",
            "Cameron",
            "Carl",
            "Charles",
            "Christian",
            "Christopher",
            "Colin",
            "Connor",
            "Dan",
            "David",
            "Dominic",
            "Dylan",
            "Edward",
            "Eric",
            "Evan",
            "Frank",
            "Gavin",
            "Gordon",
            "Harry",
            "Ian",
            "Isaac",
            "Jack",
            "Jacob",
            "Jake",
            "James",
            "Jason",
            "Joe",
            "John",
            "Jonathan",
            "Joseph",
            "Joshua",
            "Julian",
            "Justin",
            "Keith",
            "Kevin",
            "Leonard",
            "Liam",
            "Lucas",
            "Luke",
            "Matt",
            "Max",
            "Michael",
            "Nathan",
            "Neil",
            "Nicholas",
            "Oliver",
            "Owen",
            "Paul",
            "Peter",
            "Phil",
            "Piers",
            "Richard",
            "Robert",
            "Ryan",
            "Sam",
            "Sean",
            "Sebastian",
            "Simon",
            "Stephen",
            "Steven",
            "Stewart",
            "Thomas",
            "Tim",
            "Trevor",
            "Victor",
            "Warren",
            "William",
        });
        #endregion
    }
}

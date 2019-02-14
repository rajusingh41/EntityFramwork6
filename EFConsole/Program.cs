using EFCodeFirstModel;
using EFModelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDbContext dbContext = new SchoolDbContext();
            var stud = new Student() { StudentName = "Bill" };

            dbContext.Students.Add(stud);
            dbContext.SaveChanges();
        }
    }
}

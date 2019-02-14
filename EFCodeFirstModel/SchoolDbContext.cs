using EFModelEntity;
using System.Data.Entity;

namespace EFCodeFirstModel
{
    public class SchoolDbContext :DbContext
    {
        public SchoolDbContext():base("name=SchoolDBConnectionString")
        {

        }
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using System.Data.Entity;

namespace FinalChallengeAssignmenttry2
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() 
        { 
                    
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }    
    }
}

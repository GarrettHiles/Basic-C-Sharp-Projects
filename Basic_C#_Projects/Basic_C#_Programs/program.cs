namespace FinalChallengeAssignmenttry2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Billy" };
                ctx.Students.Add(stud); 
                ctx.SaveChanges();
            }
        }
    }
}

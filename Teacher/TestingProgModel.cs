namespace Teacher
{
    using System.Data.Entity;

    public class TestingProgModel : DbContext
    {

        public TestingProgModel()
            : base("name=TestingProgModel")
        {
        }

        DbSet<Class.Test> Tests;
        DbSet<Class.Teacher> Teachers;

        

    }


}
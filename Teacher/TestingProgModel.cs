namespace Teacher
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TestingProgModel : DbContext
    {
        // Your context has been configured to use a 'TestingProgModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Teacher.TestingProgModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TestingProgModel' 
        // connection string in the application configuration file.
        public TestingProgModel()
            : base("name=TestingProgModel")
        {
        }

       
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
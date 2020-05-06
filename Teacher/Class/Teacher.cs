using System.Collections.Generic;

namespace Teacher.Class
{
    class Teacher
    {
        int Id { get; }
        string Name { get; set; }
        string Surname { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        List<string> PassedTest { get;  }



    }
}

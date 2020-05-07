using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher.Class
{
    class Test
    {
        int Id { get;  }
        string NameTest { get; set; }
        int TeacherId { get; set; }
        List<Question> Questions { get;  }
    }
}

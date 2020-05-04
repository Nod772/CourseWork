using BaseTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFLogic.DTO
{
   public class TeacherDTO
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<string> PassedTest { get; set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}

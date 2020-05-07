using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestLib.Classes
{
   public class WrapperTeacher:Wrapper<Teasher>
    {
        TestModel context = null;
        public new DbSet<Teasher> Set { get; set; }

        public WrapperTeacher(TestModel model):base(model)
        {
            context = model;
            Set = model.Teashers;
        }
      


    }
}

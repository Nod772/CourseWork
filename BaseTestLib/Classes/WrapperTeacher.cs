using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestLib.Classes
{
   public class WrapperTeacher:Wrapper<Teasher>
    {
        public WrapperTeacher(TestModel model):base(model)
        {

        }


    }
}

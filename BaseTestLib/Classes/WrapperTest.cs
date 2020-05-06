using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestLib.Classes
{
    public class WrapperTest : Wrapper<Teasher>
    {
        TestModel context = null;
        public new DbSet<Test> Set { get; set; }

        public WrapperTest(TestModel model) : base(model)
        {
            context = model;
            Set = model.Tests;
        }


    }
}

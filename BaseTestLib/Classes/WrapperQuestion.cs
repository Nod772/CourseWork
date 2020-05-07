using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestLib.Classes
{
   public class WrapperQuestion : Wrapper<Question>
    {
        TestModel context = null;
        public new DbSet<Question> Set { get; set; }

        public WrapperQuestion(TestModel model) : base(model)
        {
            context = model;
            Set = model.Questions;
        }
      
    
    }
}

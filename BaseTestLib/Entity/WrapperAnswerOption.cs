using BaseTestLib.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestLib.Entity
{
    class WrapperAnswerOption : Wrapper<AnswerOption>
    {
        TestModel context = null;
        public new DbSet<AnswerOption> Set { get; set; }

        public WrapperAnswerOption(TestModel model) : base(model)
        {
            context = model;
            Set = model.AnswerOptions;
        }


    }
}

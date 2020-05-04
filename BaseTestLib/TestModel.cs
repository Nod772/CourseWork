using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestLib
{
    class TestModel:DbContext
    {
        public TestModel():base("name=TestModel")
        {

        }
        public virtual DbSet<AnswerOption> AnswerOptions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Teasher>  Teashers { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4.Models
{
    public class Child : Plan
    {
        protected string _steps;

        public Child(string name , string steps): base(name)
        {
            _steps = steps;
        }

        public override string Ways()
        {
            return _steps = "1. Begin at the beginning";
        }
        public override string EFact1()
        {
            return "1.Encourage energy efficiency";
        }

        public override string EFact2()
        {
            return "2. Explore the wonders of outdoors";
        }
        public override string EFact3()
        {
            return "3.Go gaga over gardening";
        }
        public override string EFact4()
        {
            return "4.Fun with food waste";
        }
        public override string EFact5()
        {
            return "5.Introduce early to an eco-friendly lifestyle";
        }
        public override string EFact6()
        {
            return "6.Teach kids to buy locally grown herbs,eggs and so on";
        }

    }
}
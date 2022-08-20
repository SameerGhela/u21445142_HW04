using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4
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
            return this._steps = "1. Begin at the beginning";
        }
        public override string GetInfo()
        {
            return base.GetInfo() + "a Child Plan";
        }
    }
}
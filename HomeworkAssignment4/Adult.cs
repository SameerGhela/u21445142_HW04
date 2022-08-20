using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4
{
    public class Adult: Plan
    {
        protected string _steps;

        public Adult(string name, string steps) : base(name)
        {
            _steps = steps;
        }
        public override string Ways()
        {
            return this._steps = "1. Become More Aware of Resources";
        }
        public override string GetInfo()
        {
            return base.GetInfo() + "a Adult Plan";
        }
    }
}
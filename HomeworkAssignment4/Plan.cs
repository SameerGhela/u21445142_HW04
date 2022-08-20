using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4
{
    public abstract class Plan
    {
        protected string _name;

        public Plan (string name)
        {
            _name = name;
        }
        public abstract string Ways();

        public virtual string GetInfo()
        {
            return "The plan chosen is :" + _name;
        }

    }
}
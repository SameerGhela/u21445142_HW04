using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4
{
    public class Elderly: Plan
    {
        protected string _steps;

        public Elderly(string name, string steps) : base(name)
        {
            _steps = steps;
        }

        public override string Ways()
        {
            return this._steps = "1. Give Away Household Items";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "an Elderly Plan";
        }
    }
}
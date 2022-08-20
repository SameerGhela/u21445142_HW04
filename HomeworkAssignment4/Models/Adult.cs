using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4.Models
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
            return _steps = "1. Become More Aware of Resources";
        }

        public override string EFact1()
        {
            return "1.Practice Conservation";
        }

        public override string EFact2()
        {
            return "2.Conserve Water";
        }
        public override string EFact3()
        {
            return "3.Try Renewable Energy, Go Rooftop Solar";
        }
        public override string EFact4()
        {
            return "4.Cut Down Meat on your Plate";
        }
        public override string EFact5()
        {
            return "5.Stop Food Waste";
        }
        public override string EFact6()
        {
            return "6.Use Less Fossil Fuel Based Products";
        }

    }
}
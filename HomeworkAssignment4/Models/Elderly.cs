using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4.Models
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
            return "1. Give Away Household Items";
        }

        public override string EFact1()
        {
            return "1. Give Away Household Items";
        }

        public override string EFact2()
        {
            return "2. Shop Locally";
        }
        public override string EFact3()
        {
            return "3. Start A Compost Pile";
        }
        public override string EFact4()
        {
            return "4. Focus On Energy-Efficient Products For Home";
        }
        public override string EFact5()
        {
            return "5.Use Energy-Saving and Water-Saving Tools";
        }
        public override string EFact6()
        {
            return "6.Plant a Garden";
        }
    }
}
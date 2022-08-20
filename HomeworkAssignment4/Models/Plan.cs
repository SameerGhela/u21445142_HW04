using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssignment4.Models
{
    public abstract class Plan
    {
        public string _name { get; set; }

        public Plan()
        {

        }

        public Plan(string name)
        {
            _name = name;
        }
        public abstract string Ways();

        public virtual string EFact1()
        {
            return "";
        }
        

        public abstract string EFact2();

        public abstract string EFact3();

        public abstract string EFact4();

        public abstract string EFact5();

        public abstract string EFact6();
      

    }
}
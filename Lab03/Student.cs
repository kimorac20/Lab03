using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Student:Person
    {
        public double Average { get; set; }

        public override string GetSummary()
        {
            return base.GetSummary() + ", AVG: " + Average;
        }
    }
}

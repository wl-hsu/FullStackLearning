using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    public abstract class Person
    {
        List<string> addresses {  get; set; }
        public abstract int CalculateAge();

        public decimal CalculateSalary()
        {
            decimal salary = 0;
            return salary;
        }


    }
}

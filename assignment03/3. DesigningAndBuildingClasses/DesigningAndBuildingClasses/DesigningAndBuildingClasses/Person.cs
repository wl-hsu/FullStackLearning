using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    public abstract class Person: IPersonService
    {
        DateTime Birthday { get; set; }
        List<string> addresses {  get; set; }
        public int CalculateAge()
        {
            return DateTime.Today.Year - Birthday.Year;
        }

        public  decimal CalculateSalary()
        {
            int salary = 1;
            return salary;
        }



    }
}

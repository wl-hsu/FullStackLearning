using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    public class Instructor : Person, IInstructorService
    {
        string department;
        int identificationInDepartment;
        DateTime employeedDate;
        

        public override int CalculateAge()
        {
            throw new NotImplementedException();
        }

        public decimal calculateBonoud(DateTime employeedDate)
        {
            throw new NotImplementedException();
        }

        public override decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }

    }
}

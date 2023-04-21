using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    public  interface IPersonService
    {
        public abstract int CalculateAge();

        public abstract decimal CalculateSalary();
    }
}

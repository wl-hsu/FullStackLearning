using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    internal class Student : Person, IStudent
    {
        List<Integer> registeredCourseCode { get; set; }
        public override int CalculateAge()
        {
            throw new NotImplementedException();
        }

        public string CalculateGrade()
        {
            throw new NotImplementedException();
        }
    }
}

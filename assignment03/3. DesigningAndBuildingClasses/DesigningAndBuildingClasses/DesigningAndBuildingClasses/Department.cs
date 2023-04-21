using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    public class Department
    {   
        DateTime startDate {  get; set; }
        DateTime endDate { get; set; }
        string department { get; set; }
        Instructor instructor { get; set; }
        List<Student> students { get; set; }

        List<Course> courses { get; set; }
    }
}

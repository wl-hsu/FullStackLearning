using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class JobRequestModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime? StarDate { get; set; }

        public int NumberOfPositions { get; set; }
    }
}

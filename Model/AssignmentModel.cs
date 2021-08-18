using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentAPI.Model
{
    public class AssignmentModel
    {
        public string AssignmentID { get; set; }
        public string AssignmentName { get; set; }

        public string AssignmentDescription { get; set; }

        public string AssignmentType { get; set; }

        public string AssignmentDuration { get; set; }
        public IList<string> Tags { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentAPI.Model
{
    public class AssignmentModel
    {
        public string AssignmentID { get; set; }
        [Required(ErrorMessage ="Assignment Name is mandatory")]
        public string AssignmentName { get; set; }

        public string AssignmentDescription { get; set; }

        [Required(ErrorMessage ="Assignment Type is mandatory")]
        public string AssignmentType { get; set; }

        public string AssignmentDuration { get; set; }
        public IList<string> Tags { get; set; }
    }
}

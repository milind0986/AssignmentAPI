using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentAPI.Model;

namespace AssignmentAPI.Repository
{
    public interface IAssignmentRepository
    {
        public AssignmentModel GetAssignments(string assignmentId);

        public IList<AssignmentModel> GetAssignments();

        public IList<AssignmentModel> GetAssignmentsByTag(string tagId);

        public string AddAssignment(AssignmentModel assignment);
       
    }
}

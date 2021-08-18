using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentAPI.Model;

namespace AssignmentAPI.Repository
{
    public class AssignmentRepository: IAssignmentRepository
    {
        public IList<AssignmentModel> assignmentList = null;

        public IList<AssignmentModel> GetAssignments()
        {
            return assignmentList;
        }

        public AssignmentModel GetAssignments(string assignmentId)
        {
            if (assignmentId !=null)
                return assignmentList.Where(a => a.AssignmentID == assignmentId).SingleOrDefault();
            else
                return MockObject();
        }

        public IList<AssignmentModel> GetAssignmentsByTag(string tagId)
        {
            if (tagId != null)
                return assignmentList.Where(a => a.Tags.Contains(tagId)).ToList<AssignmentModel>();
            else
                return null;
        }

        public string AddAssignment(AssignmentModel assignment)
        {
            if(assignmentList == null)
            {
                assignmentList = new List<AssignmentModel>();
            }
            assignment.AssignmentID = new Random().Next(1,9999).ToString();
            assignmentList.Add(assignment);
            return "Assignment Created";
        }

        private AssignmentModel MockObject()
        {
            AssignmentModel model = new AssignmentModel();
            var rng = new Random();
            string[] tagList = { "tag1","tag2"};
            model.AssignmentDescription = "Assignment Description";
            model.AssignmentID = rng.Next().ToString();
            model.AssignmentType = "Test";
            model.AssignmentDuration = "12";
            model.Tags = tagList;

            return model;
        }
    }
}

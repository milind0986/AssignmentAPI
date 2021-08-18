using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentAPI.Model;
using AssignmentAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentAPI.Controllers
{
    public class AssignmentController : Controller
    {
        public IAssignmentRepository todoItem { get; set; }

        public AssignmentController(IAssignmentRepository _repo)
        {
            todoItem = _repo;
        }

        [HttpGet]
        [Route("api/assignment")]
        public AssignmentModel Get(string assignmentId)
        {
            return todoItem.GetAssignments(assignmentId);
        }

        [HttpGet]
        [Route("api/assignment/GetAssignments")]
        public IList<AssignmentModel> GetAssignments()
        {
            return todoItem.GetAssignments();
        }

        [HttpGet]
        [Route("api/assignment/GetAssignmentsByTag")]
        public IList<AssignmentModel> GetAssignmentsByTag(string tagId)
        {
            return todoItem.GetAssignmentsByTag(tagId);
        }

        [HttpPost]
        [Route("api/assignment")]
        public IActionResult Post([FromBody]AssignmentModel model)
        {
            if (model != null)
                todoItem.AddAssignment(model);
            return RedirectToAction("GetAssignments");
        }
    }
}

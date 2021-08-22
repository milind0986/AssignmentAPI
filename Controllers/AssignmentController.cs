using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentAPI.Model;
using AssignmentAPI.Repository;
using Microsoft.AspNetCore.Http;
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
            try
            {
                if (model == null)
                {
                    return BadRequest();
                }
                else
                {
                    if (ModelState.IsValid)
                        todoItem.AddAssignment(model);
                    else
                        return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
            "Error inserting data into the database(Post : AssignmentController) Error Message " + ex.InnerException);
            }

            return RedirectToAction("GetAssignments");
        }
    }
}

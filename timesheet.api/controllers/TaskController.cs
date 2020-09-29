using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timesheet.business;

namespace timesheet.api.controllers
{
    [Route("api/v1/task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }


        [HttpGet("getTasks")]
        public IActionResult GetAllTasks()
        {
            try
            {
                var taskDetails = this._taskService.GetTaskDetails();
                return new ObjectResult(taskDetails);
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex);
            }
        }
    }
}

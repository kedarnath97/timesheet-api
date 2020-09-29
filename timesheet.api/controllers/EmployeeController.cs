using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timesheet.business;

namespace timesheet.api.controllers
{
    [Route("api/v1/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll(string text)
        {
            try
            {
                var items = this._employeeService.GetEmployees();
                return new ObjectResult(items);
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex);
            }
        }
    }
}
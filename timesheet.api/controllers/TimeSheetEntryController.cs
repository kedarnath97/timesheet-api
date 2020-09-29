using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using timesheet.business;

namespace timesheet.api.controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/v1/timesheetentry")]
    [ApiController]
    public class TimeSheetEntryController : ControllerBase
    {
        private EmployeeWorkHourService _timesheetService;

        public TimeSheetEntryController(EmployeeWorkHourService timeSheetEntryService)
        {
            _timesheetService = timeSheetEntryService;
        }
        [Microsoft.AspNetCore.Mvc.HttpGet("getAllTimeSheetData")]
        public IActionResult GetAll()
        {
            try
            {
                var tsEntryData = this._timesheetService.GetEmployeeWorkTimes();
                return new ObjectResult(tsEntryData);
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex);
            }
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("getTimeSheetDataForUser")]
        public IActionResult GetUserTimeSheetData([FromUri] string usercode)
        {

            try
            {
                var tsEntryData = this._timesheetService.GetEmployeeWorkTimes();
                var filteredData = tsEntryData.Where(a => a.EmployeeCode == usercode);
                return new ObjectResult(filteredData);
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex);
            }
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("getTimeSheetDataForPeriod")]
        public IActionResult GetTimeSheetDataForPeriod([FromUri] string usercode, [FromUri] string begin, [FromUri] string end)
        {
            try
            {
                var tsEntryData = this._timesheetService.GetEmployeeWorkTimes();
                var filteredData = tsEntryData.Where(a => a.EmployeeCode == usercode && a.RecordDate >= DateTime.ParseExact(begin, "yyyyMMdd", null) && a.RecordDate <= DateTime.ParseExact(end, "yyyyMMdd", null));
                return new ObjectResult(filteredData);
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex);
            }
        }

        [Microsoft.AspNetCore.Mvc.HttpPost("addUpdateTimeSheetEntry")]
        public IActionResult EditUpdateTimeSheetRecord([Microsoft.AspNetCore.Mvc.FromBody] List<model.EmployeeWorkTime> timeSheetRecords)
        {
            try
            {
                foreach (var item in timeSheetRecords)
                {
                    _timesheetService.EditUpdateTimeSheet(item);
                }
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex);
            }
            return new ObjectResult(true);
        }
    }
}

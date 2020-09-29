using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using timesheet.data;
using timesheet.model;

namespace timesheet.business
{
    public class EmployeeWorkHourService
    {
        private TimesheetDb _timeSheetDb;

        public EmployeeWorkHourService(TimesheetDb timeSheetDB)
        {
            _timeSheetDb = timeSheetDB;
        }

        public IQueryable<timesheet.model.EmployeeWorkTime> GetEmployeeWorkTimes()
        {
            return _timeSheetDb.EmployeeTaskHours;
        }

        public void EditUpdateTimeSheet(EmployeeWorkTime timeSheetRecord)
        {
            var item = _timeSheetDb.EmployeeTaskHours.SingleOrDefault(a => a.EmployeeCode == timeSheetRecord.EmployeeCode && a.RecordDate == timeSheetRecord.RecordDate && a.TaskId == timeSheetRecord.TaskId);
            if (item == null)
            {
                _timeSheetDb.Add(timeSheetRecord);
            }
            else
            {
                item.TaskHours = timeSheetRecord.TaskHours;
                item.TaskId = timeSheetRecord.TaskId;
            }
            _timeSheetDb.SaveChanges();

        }
    }
}

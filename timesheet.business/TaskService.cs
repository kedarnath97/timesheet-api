using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using timesheet.data;

namespace timesheet.business
{
    public class TaskService
    {
        private TimesheetDb _timeSheetDb;

        public TaskService(TimesheetDb db)
        {
            _timeSheetDb = db;
        }

        public IQueryable<timesheet.model.Task> GetTaskDetails()
        {
            return _timeSheetDb.Tasks;
        }
    }
}

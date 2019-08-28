using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTimesheet.Interfaces;
using WebApplicationTimesheet.Model;

namespace WebApplicationTimesheet.Repositories
{
    /// <summary>
    /// Репозиторий табеля учета.
    /// </summary>
    public class TimesheetRepository : ITimesheetRepository
    {
        /// <summary>
        /// Регистрация отсутствия сотрудника в табеле.
        /// </summary>
        /// <param name="timesheet">Табель учета.</param>
        public void Save(Timesheet timesheet)
        {
            string sql_query = $@"
insert into timesheet.timesheet
(
    employee_id
    date,
    time,
    reason
)
values
(
    @{nameof(Employee.ID)},
    @{nameof(Timesheet.Date)},
    @{nameof(Timesheet.Time)},
    @{nameof(Timesheet.Reason)}
)
";
        }
    }
}

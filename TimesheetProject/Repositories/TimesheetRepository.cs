using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Interfaces;
using Timesheet.Model;

namespace Timesheet.Repositories
{
    /// <summary>
    /// Репозиторий табеля учета.
    /// </summary>
    public class TimesheetRepository : ITimesheetRepository
    {
        /// <summary>
        /// Регистрация отсутствия сотрудника.
        /// </summary>
        /// <param name="timesheet">Табель учета.</param>
        public void Save(Timesheet timesheet)
        {

        }
    }
}

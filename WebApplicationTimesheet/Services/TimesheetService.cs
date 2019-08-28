using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTimesheet.Interfaces;
using WebApplicationTimesheet.Model;

namespace WebApplicationTimesheet.Services
{
    /// <summary>
    /// Сервис табеля учета.
    /// </summary>
    public class TimesheetService : ITimesheetService
    {
        #region Properties

        /// <summary>
        /// Репозиторий табеля учета.
        /// </summary>
        public ITimesheetRepository _timesheetRepository { get; set; }

        #endregion

        /// <summary>
        /// Инициализация структур.
        /// </summary>
        /// <param name="timesheet_repository"></param>
        public TimesheetService(ITimesheetRepository timesheet_repository)
        {
            _timesheetRepository = timesheet_repository;
        }

        /// <summary>
        /// Регистрация отсутствия сотрудника в табеле.
        /// </summary>
        /// <param name="timesheet">Табель учета.</param>
        public void Save(Timesheet timesheet)
        {
            _timesheetRepository.Save(timesheet);
        }
    }
}

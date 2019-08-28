using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheet.Interfaces;
using Timesheet.Model;

namespace Timesheet.Services
{
    /// <summary>
    /// Сервис валидации формы табеля учета.
    /// </summary>
    public class ValidateService : IValidateService
    {
        public bool FIO(string text)
        {
            return true;
        }

        public bool Position(string text)
        {
            return true;
        }

        /// <summary>
        /// Проверяет, что дата не больше текущего момента.
        /// </summary>
        /// <param name="datetime">Дата.</param>
        /// <returns>Признак правильности даты.</returns>
        public bool Datetime(DateTime datetime)
        {


            return true;
        }

        public bool Reason(string text)
        {
            return true;
        }

        public bool Timesheet(Timesheet timesheet)
        {
            return FIO(timesheet.Employee.FIO)
                && Position(timesheet.Employee.Position)
                && Datetime(timesheet.Date)
                && Reason(timesheet.Reason);
        }
    }
}

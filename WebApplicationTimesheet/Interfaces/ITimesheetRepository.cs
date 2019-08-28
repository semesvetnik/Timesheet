using WebApplicationTimesheet.Model;

namespace WebApplicationTimesheet.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория табеля учета.
    /// </summary>
    public interface ITimesheetRepository
    {
        /// <summary>
        /// Регистрация отсутствия сотрудника в табеле.
        /// </summary>
        /// <param name="timesheet">Табель учета.</param>
        void Save(Timesheet timesheet);
    }
}
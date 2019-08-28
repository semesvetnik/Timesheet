using System.Collections.Generic;

namespace Timesheet.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория сотрудника.
    /// </summary>
    public interface IEmployeeRepository
    {
        IEnumerable<string> GetFIOList(string text);
        IEnumerable<string> GetPositionList(string text);
    }
}
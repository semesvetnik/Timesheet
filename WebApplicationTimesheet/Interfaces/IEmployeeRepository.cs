using System.Collections.Generic;

namespace WebApplicationTimesheet.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория сотрудника.
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Возвращает список фамилий по образцу.
        /// </summary>
        /// <param name="name">Образец.</param>
        /// <returns>Список фамилий.</returns>
        IEnumerable<string> GetFIOList(string name);
    }
}
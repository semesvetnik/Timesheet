using System.Collections.Generic;

namespace WebApplicationTimesheet.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса ФИО.
    /// </summary>
    public interface IEployeeService
    {
        /// <summary>
        /// Возвращает список фамилий по образцу.
        /// </summary>
        /// <param name="name">Образец.</param>
        /// <returns>Список фамилий.</returns>
        IEnumerable<string> GetFIOList(string name);
    }
}
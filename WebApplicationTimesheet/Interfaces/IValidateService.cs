
using System;
using WebApplicationTimesheet.Model;

namespace WebApplicationTimesheet.Interfaces
{
    /// <summary>
    /// Сервис валидации.
    /// </summary>
    public interface IValidateService
    {
        /// <summary>
        /// Проверяет, что дата не больше текущего момента.
        /// </summary>
        /// <param name="datetime">Дата.</param>
        /// <returns>Признак правильности даты.</returns>
        bool Datetime(DateTime datetime);
    }
}
using System.Collections.Generic;

namespace WebApplicationTimesheet.Interfacess
{
    /// <summary>
    /// Интерфейс сервиса должности.
    /// </summary>
    public interface IPositionService
    {
        /// <summary>
        /// Возвращает список должностей по образцу.
        /// </summary>
        /// <param name="text">Образец.</param>
        /// <returns>Список должностей.</returns>
        IEnumerable<string> GetPositionList(string text);
    }
}